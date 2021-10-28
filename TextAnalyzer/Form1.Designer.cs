
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
            this.longBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total_words = new System.Windows.Forms.Label();
            this.total_uniq_words = new System.Windows.Forms.Label();
            this.percentage_of_chars = new System.Windows.Forms.Label();
            this.percentageBox = new System.Windows.Forms.TextBox();
            this.frequentBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.total_words_lable = new System.Windows.Forms.Label();
            this.total_unique_words_lable = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(976, 247);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сбросToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьФайлToolStripMenuItem.Text = "Открыть";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сбросToolStripMenuItem.Text = "Сброс";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // longBox
            // 
            this.longBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.longBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.longBox.Location = new System.Drawing.Point(12, 321);
            this.longBox.Multiline = true;
            this.longBox.Name = "longBox";
            this.longBox.Size = new System.Drawing.Size(226, 385);
            this.longBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top long words";
            // 
            // total_words
            // 
            this.total_words.AutoSize = true;
            this.total_words.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_words.Location = new System.Drawing.Point(740, 286);
            this.total_words.Name = "total_words";
            this.total_words.Size = new System.Drawing.Size(141, 32);
            this.total_words.TabIndex = 6;
            this.total_words.Text = "Total words:";
            // 
            // total_uniq_words
            // 
            this.total_uniq_words.AutoSize = true;
            this.total_uniq_words.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_uniq_words.Location = new System.Drawing.Point(706, 478);
            this.total_uniq_words.Name = "total_uniq_words";
            this.total_uniq_words.Size = new System.Drawing.Size(223, 32);
            this.total_uniq_words.TabIndex = 7;
            this.total_uniq_words.Text = "Total unique words:";
            // 
            // percentage_of_chars
            // 
            this.percentage_of_chars.AutoSize = true;
            this.percentage_of_chars.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage_of_chars.Location = new System.Drawing.Point(238, 286);
            this.percentage_of_chars.Name = "percentage_of_chars";
            this.percentage_of_chars.Size = new System.Drawing.Size(160, 32);
            this.percentage_of_chars.TabIndex = 8;
            this.percentage_of_chars.Text = "Total chars %:";
            // 
            // percentageBox
            // 
            this.percentageBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.percentageBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.percentageBox.Location = new System.Drawing.Point(244, 321);
            this.percentageBox.Multiline = true;
            this.percentageBox.Name = "percentageBox";
            this.percentageBox.Size = new System.Drawing.Size(154, 385);
            this.percentageBox.TabIndex = 9;
            // 
            // frequentBox
            // 
            this.frequentBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.frequentBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.frequentBox.Location = new System.Drawing.Point(404, 321);
            this.frequentBox.Multiline = true;
            this.frequentBox.Name = "frequentBox";
            this.frequentBox.Size = new System.Drawing.Size(217, 385);
            this.frequentBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Top frequent words";
            // 
            // total_words_lable
            // 
            this.total_words_lable.AutoSize = true;
            this.total_words_lable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_words_lable.Location = new System.Drawing.Point(792, 366);
            this.total_words_lable.Name = "total_words_lable";
            this.total_words_lable.Size = new System.Drawing.Size(0, 38);
            this.total_words_lable.TabIndex = 12;
            // 
            // total_unique_words_lable
            // 
            this.total_unique_words_lable.AutoSize = true;
            this.total_unique_words_lable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_unique_words_lable.Location = new System.Drawing.Point(792, 574);
            this.total_unique_words_lable.Name = "total_unique_words_lable";
            this.total_unique_words_lable.Size = new System.Drawing.Size(0, 38);
            this.total_unique_words_lable.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 718);
            this.Controls.Add(this.total_unique_words_lable);
            this.Controls.Add(this.total_words_lable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frequentBox);
            this.Controls.Add(this.percentageBox);
            this.Controls.Add(this.percentage_of_chars);
            this.Controls.Add(this.total_uniq_words);
            this.Controls.Add(this.total_words);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longBox);
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
        private System.Windows.Forms.TextBox longBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_words;
        private System.Windows.Forms.Label total_uniq_words;
        private System.Windows.Forms.Label percentage_of_chars;
        private System.Windows.Forms.TextBox percentageBox;
        private System.Windows.Forms.TextBox frequentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_words_lable;
        private System.Windows.Forms.Label total_unique_words_lable;
    }
}

