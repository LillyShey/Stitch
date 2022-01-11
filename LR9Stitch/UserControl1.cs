using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR9Stitch {
    public partial class Polotno : UserControl {
        public Polotno() {
            InitializeComponent();
        }
        public Color ActiveColor = Color.Red;

        public string protokol = "";
        private bool doPaint;
        public bool fill;
        public int symm = 0;
        public int CWid, CHig; //Ширина і висота в 
                               //квадратиках
        int CrossWidth = 8;

        void AddCross(MouseEventArgs e, int x, int y) {
            //додаємо "клаць" до протоколу
            //вилучивши, за потреби, вже наявного хрестика 
            //в цій точці

            int X = x / CrossWidth * CrossWidth;
            int Y = y / CrossWidth * CrossWidth;

            for (int p = 0; p < protokol.Length; p += 26)
                if ((X == int.Parse(protokol.Substring(p, 5))) && Y == int.Parse(protokol.Substring(p + 5, 5))) { protokol = protokol.Remove(p, 26); break; }
            protokol += string.Format("{0,5}{1,5}{2,4}{3,4}{4,4}{5,4}", X, Y, ActiveColor.A.ToString(), ActiveColor.R.ToString(), ActiveColor.G.ToString(), ActiveColor.B.ToString());
        }
        public void Clear() {
            protokol = "";
            Invalidate();
        }

        private void Polotno_MouseClick(object sender, MouseEventArgs e) {
            //ставимо хрестик в точці клацання
            AddCross(e, e.X, e.Y);
            if (symm >= 3) //центральна
                AddCross(e, CWid * (CrossWidth) - e.X - 1,
                            CHig * (CrossWidth) - e.Y - 1);
            if ((symm == 1) || (symm == 3)) // вертикальна вісь
                AddCross(e, CWid * (CrossWidth) - e.X - 1, e.Y);
            if ((symm == 2) || (symm == 3)) // горизонтальна вісь
                AddCross(e, e.X, CHig * (CrossWidth) - e.Y - 1);

            Invalidate();
        }

        private void Polotno_Paint(object sender, PaintEventArgs e) {
            SolidBrush B = new SolidBrush(ActiveColor);
            if (fill) {
                for (int x = 0; x < protokol.Length; x += 26)
                    e.Graphics.FillRectangle(B, int.Parse(protokol.Substring(x, 5)), int.Parse(protokol.Substring(x + 5, 5)), CrossWidth - 1, CrossWidth - 1);
            }
            for (int x = 0; x < protokol.Length; x += 26) {// малюємо прямокутнички за даними протоколу
                B.Color = Color.FromArgb(int.Parse(protokol.Substring(x + 10, 4)), int.Parse(protokol.Substring(x + 14, 4)), int.Parse(protokol.Substring(x + 18, 4)), int.Parse(protokol.Substring(x + 22, 4)));
                e.Graphics.FillRectangle(B, int.Parse(protokol.Substring(x, 5)), int.Parse(protokol.Substring(x + 5, 5)), CrossWidth - 1, CrossWidth - 1);
            }
        }

        //Якщо клавіша мишки піднімається, булева змінна doPaint набуває значення false
        private void Polotno_MouseUp(object sender, MouseEventArgs e) {
            doPaint = false;
        }

        //Якщо клавіша мишки відпускається, булева змінна doPaint набуває значення false
        private void Polotno_MouseLeave(object sender, EventArgs e) {
            doPaint = false;
        }

        //Якщо клавіша мишки опускається, булева змінна doPaint набуває значення true
        private void Polotno_MouseDown(object sender, MouseEventArgs e) {
            doPaint = true;
        }
        //Якщо мишка рухається, перевіряється, чи doPaint true і викликається подія Mouse_Click
        private void Polotno_MouseMove(object sender, MouseEventArgs e) {
            if (doPaint)
                Polotno_MouseClick(sender, e);
        }

        private void Polotno_SizeChanged(object sender, EventArgs e) {
            CWid = Width / CrossWidth;
            CHig = Height / CrossWidth;
        }

    }
}