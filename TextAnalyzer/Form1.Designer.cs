
namespace TextAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоУникальныхСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыхДлинныхСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыхЧастыхСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процентноеСоотношениеБуквToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 247);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сбросToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьФайлToolStripMenuItem.Text = "Открыть";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сбросToolStripMenuItem.Text = "Сброс";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox2.Location = new System.Drawing.Point(12, 321);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(698, 385);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Statistics:";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоСловToolStripMenuItem,
            this.количествоУникальныхСловToolStripMenuItem,
            this.самыхДлинныхСловToolStripMenuItem,
            this.самыхЧастыхСловToolStripMenuItem,
            this.процентноеСоотношениеБуквToolStripMenuItem});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // количествоСловToolStripMenuItem
            // 
            this.количествоСловToolStripMenuItem.Name = "количествоСловToolStripMenuItem";
            this.количествоСловToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.количествоСловToolStripMenuItem.Text = "Количество слов";
            this.количествоСловToolStripMenuItem.Click += new System.EventHandler(this.количествоСловToolStripMenuItem_Click);
            // 
            // количествоУникальныхСловToolStripMenuItem
            // 
            this.количествоУникальныхСловToolStripMenuItem.Name = "количествоУникальныхСловToolStripMenuItem";
            this.количествоУникальныхСловToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.количествоУникальныхСловToolStripMenuItem.Text = "Количество уникальных слов";
            // 
            // самыхДлинныхСловToolStripMenuItem
            // 
            this.самыхДлинныхСловToolStripMenuItem.Name = "самыхДлинныхСловToolStripMenuItem";
            this.самыхДлинныхСловToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.самыхДлинныхСловToolStripMenuItem.Text = "10 самых длинных слов";
            // 
            // самыхЧастыхСловToolStripMenuItem
            // 
            this.самыхЧастыхСловToolStripMenuItem.Name = "самыхЧастыхСловToolStripMenuItem";
            this.самыхЧастыхСловToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.самыхЧастыхСловToolStripMenuItem.Text = "10 самых частых слов";
            // 
            // процентноеСоотношениеБуквToolStripMenuItem
            // 
            this.процентноеСоотношениеБуквToolStripMenuItem.Name = "процентноеСоотношениеБуквToolStripMenuItem";
            this.процентноеСоотношениеБуквToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.процентноеСоотношениеБуквToolStripMenuItem.Text = "Процентное соотношение букв";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TextAnalizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоУникальныхСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыхДлинныхСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыхЧастыхСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процентноеСоотношениеБуквToolStripMenuItem;
    }
}

