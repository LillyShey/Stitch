
namespace LR9Stitch
{
    partial class Polotno
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Polotno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Polotno";
            this.SizeChanged += new System.EventHandler(this.Polotno_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Polotno_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Polotno_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Polotno_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Polotno_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Polotno_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Polotno_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
