using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR9Stitch {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void RBGoriz_CheckedChanged(object sender, EventArgs e) {
            polotno1.symm = 2;
        }

        private void RBWert_CheckedChanged(object sender, EventArgs e) {
            polotno1.symm = 1;
        }

        private void RBDwi_CheckedChanged(object sender, EventArgs e) {
            polotno1.symm = 3;
        }

        private void RBCentr_CheckedChanged(object sender, EventArgs e) {
            polotno1.symm = 4;
        }

        private void Form1_Load(object sender, EventArgs e) {
            polotno1.symm = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
            polotno1.ActiveColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e) {
            polotno1.Clear();
        }
        private void writeToFile(string protokol, string path) {
            try {
                //Створюємо бінарну файлову змінну яка відкриватиме файл за заданим шляхом лише для читання
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create))) {
                    //Записуємо туди наш протокол
                    writer.Write(protokol);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                //Для saveFileDialog встановлюємо фільтр лише на бінарні файли
                saveFileDialog1.Filter = saveFileDialog1.Filter = "Binary files(*.dat)|*.dat";
                //Якщо при відкритті saveFileDialog натискається кнопка Cancel ми виходимо з вікна, що відкрилось
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                //Створюємо строку яка зберігатиме шлях до нашого файлу
                string path = saveFileDialog1.FileName;
                //Записуємо до файлу протокол нашого полотна
                writeToFile(polotno1.protokol, path);
                MessageBox.Show("Файл збережено за шляхом " + saveFileDialog1.FileName);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void картинкуToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                //Для saveFileDialog встановлюємо фільтр лише на зображення
                savePictureDialog1.Filter =
                    "PNG|*.png|" +
                    "JPEG|*.jpeg; *.jpg; *.jpe; *.jfif|" +
                    "BMP|*.bmp|" +
                    "GIF pictures|*.gif";
                //Якщо при відкритті savePictureDialog натискається кнопка Cancel ми виходимо з вікна, що відкрилось
                if (savePictureDialog1.ShowDialog() == DialogResult.Cancel) return;
                //Викликаємо метод SavePicture і зберігаємо його
                SavePicture().Save(savePictureDialog1.FileName);
                MessageBox.Show("Зображення збережено за шляхом " + savePictureDialog1.FileName);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private Bitmap SavePicture() {
            int k = 30;
            //Сторюємо бітову карту розміром нашого полотна збільшеного на 30
            Bitmap picture = new Bitmap(polotno1.Width + k, polotno1.Height + k);

            //Запомнюємо нашу бітову карту білими пікселями
            for (int x = 0; x < picture.Width; x++) {
                for (int y = 0; y < picture.Height; y++) {
                    picture.SetPixel(x, y, Color.White);
                }
            }
            //Записуємо протокол нашого полотна з видаленими початковими
            //і кінцевими символами-роздільниками в тимчасову змінну 
            var temp = polotno1.protokol.Trim();
            //Заміняємо в нашій тимчасовій змінній один і більше пробілів
            //лише на один пробіл
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"\s+", " ");

            string tempNumb = string.Empty;
            //Створюємо масив на шість елементів, який зберігатиме координати пікселя,
            //прозорість так колір в цвітоваій палітрі RGB 
            int[] Point = new int[6];
            //Заповнюємо наш масив кольоровими пікселями 
            for (int i = 0, ArrayPlace = 0; i < temp.Length; i++) {
                if (temp[i] == ' ') {
                    Point[ArrayPlace] = Convert.ToInt32(tempNumb);
                    tempNumb = string.Empty;
                    ArrayPlace++;
                }
                else {
                    if (ArrayPlace == 6) {
                        ArrayPlace = 0;
                        picture.SetPixel(Point[0], Point[1],
                            Color.FromArgb(Point[2], Point[3], Point[4], Point[5]));
                    }
                }
                tempNumb += temp[i];
            }
            return picture;
        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                //Для openFileDialog встановлюємо фільтр лише на бінарні файли
                openFileDialog1.Filter = saveFileDialog1.Filter = "Binary files(*.dat)|*.dat";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                string path = openFileDialog1.FileName;
                //Зчитуємо файл в бінарну файлову змінну
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open))) {
                    //Записуємо її в протокол нашого полотна
                    polotno1.protokol = reader.ReadString();
                    polotno1.Invalidate();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void друкToolStripMenuItem_Click(object sender, EventArgs e) {
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            e.Graphics.DrawImage(SavePicture(), 0, 0);
        }
    }
}
