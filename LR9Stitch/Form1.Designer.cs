
namespace LR9Stitch
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RBGoriz = new System.Windows.Forms.RadioButton();
            this.RBWert = new System.Windows.Forms.RadioButton();
            this.RBDwi = new System.Windows.Forms.RadioButton();
            this.RBCentr = new System.Windows.Forms.RadioButton();
            this.RBNoSym = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.друкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.polotno1 = new LR9Stitch.Polotno();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(659, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Колір";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(653, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Очистити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Симетрія";
            // 
            // RBGoriz
            // 
            this.RBGoriz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBGoriz.AutoSize = true;
            this.RBGoriz.Location = new System.Drawing.Point(659, 185);
            this.RBGoriz.Name = "RBGoriz";
            this.RBGoriz.Size = new System.Drawing.Size(130, 21);
            this.RBGoriz.TabIndex = 3;
            this.RBGoriz.TabStop = true;
            this.RBGoriz.Text = "Горизонтальна";
            this.RBGoriz.UseVisualStyleBackColor = true;
            this.RBGoriz.CheckedChanged += new System.EventHandler(this.RBGoriz_CheckedChanged);
            // 
            // RBWert
            // 
            this.RBWert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBWert.AutoSize = true;
            this.RBWert.Location = new System.Drawing.Point(659, 225);
            this.RBWert.Name = "RBWert";
            this.RBWert.Size = new System.Drawing.Size(123, 21);
            this.RBWert.TabIndex = 4;
            this.RBWert.TabStop = true;
            this.RBWert.Text = "Веритикальна";
            this.RBWert.UseVisualStyleBackColor = true;
            this.RBWert.CheckedChanged += new System.EventHandler(this.RBWert_CheckedChanged);
            // 
            // RBDwi
            // 
            this.RBDwi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBDwi.AutoSize = true;
            this.RBDwi.Location = new System.Drawing.Point(659, 265);
            this.RBDwi.Name = "RBDwi";
            this.RBDwi.Size = new System.Drawing.Size(72, 21);
            this.RBDwi.TabIndex = 5;
            this.RBDwi.TabStop = true;
            this.RBDwi.Text = "Дві осі";
            this.RBDwi.UseVisualStyleBackColor = true;
            this.RBDwi.CheckedChanged += new System.EventHandler(this.RBDwi_CheckedChanged);
            // 
            // RBCentr
            // 
            this.RBCentr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBCentr.AutoSize = true;
            this.RBCentr.Location = new System.Drawing.Point(659, 302);
            this.RBCentr.Name = "RBCentr";
            this.RBCentr.Size = new System.Drawing.Size(110, 21);
            this.RBCentr.TabIndex = 6;
            this.RBCentr.TabStop = true;
            this.RBCentr.Text = "Центральна";
            this.RBCentr.UseVisualStyleBackColor = true;
            this.RBCentr.CheckedChanged += new System.EventHandler(this.RBCentr_CheckedChanged);
            // 
            // RBNoSym
            // 
            this.RBNoSym.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBNoSym.AutoSize = true;
            this.RBNoSym.Location = new System.Drawing.Point(659, 340);
            this.RBNoSym.Name = "RBNoSym";
            this.RBNoSym.Size = new System.Drawing.Size(110, 21);
            this.RBNoSym.TabIndex = 7;
            this.RBNoSym.TabStop = true;
            this.RBNoSym.Text = "Без симетрії";
            this.RBNoSym.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиЯкToolStripMenuItem,
            this.завантажитиToolStripMenuItem,
            this.друкToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.картинкуToolStripMenuItem});
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // картинкуToolStripMenuItem
            // 
            this.картинкуToolStripMenuItem.Name = "картинкуToolStripMenuItem";
            this.картинкуToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.картинкуToolStripMenuItem.Text = "Зображення";
            this.картинкуToolStripMenuItem.Click += new System.EventHandler(this.картинкуToolStripMenuItem_Click);
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.завантажитиToolStripMenuItem.Text = "Завантажити";
            this.завантажитиToolStripMenuItem.Click += new System.EventHandler(this.завантажитиToolStripMenuItem_Click);
            // 
            // друкToolStripMenuItem
            // 
            this.друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            this.друкToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.друкToolStripMenuItem.Text = "Друк";
            this.друкToolStripMenuItem.Click += new System.EventHandler(this.друкToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // polotno1
            // 
            this.polotno1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polotno1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.polotno1.Location = new System.Drawing.Point(12, 31);
            this.polotno1.Name = "polotno1";
            this.polotno1.Size = new System.Drawing.Size(624, 450);
            this.polotno1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.polotno1);
            this.Controls.Add(this.RBNoSym);
            this.Controls.Add(this.RBCentr);
            this.Controls.Add(this.RBDwi);
            this.Controls.Add(this.RBWert);
            this.Controls.Add(this.RBGoriz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Редактор візерунків";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBGoriz;
        private System.Windows.Forms.RadioButton RBWert;
        private System.Windows.Forms.RadioButton RBDwi;
        private System.Windows.Forms.RadioButton RBCentr;
        private System.Windows.Forms.RadioButton RBNoSym;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Polotno polotno1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem друкToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog savePictureDialog1;
        private System.Windows.Forms.ToolStripMenuItem завантажитиToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

