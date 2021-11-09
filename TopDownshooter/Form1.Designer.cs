
namespace TopDownshooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.barHealth = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pressEnter = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.txtBestScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(9, 7);
            this.txtAmmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(93, 24);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtKills
            // 
            this.txtKills.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKills.AutoSize = true;
            this.txtKills.BackColor = System.Drawing.Color.Transparent;
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.ForeColor = System.Drawing.Color.White;
            this.txtKills.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtKills.Location = new System.Drawing.Point(649, 7);
            this.txtKills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(71, 24);
            this.txtKills.TabIndex = 1;
            this.txtKills.Text = "Kills: 0";
            this.txtKills.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Health
            // 
            this.Health.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Health.AutoSize = true;
            this.Health.BackColor = System.Drawing.Color.Transparent;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(1241, 12);
            this.Health.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(76, 24);
            this.Health.TabIndex = 2;
            this.Health.Text = "Health ";
            // 
            // barHealth
            // 
            this.barHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barHealth.BackColor = System.Drawing.Color.Black;
            this.barHealth.ForeColor = System.Drawing.Color.Black;
            this.barHealth.Location = new System.Drawing.Point(1313, 11);
            this.barHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barHealth.Name = "barHealth";
            this.barHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barHealth.Size = new System.Drawing.Size(116, 21);
            this.barHealth.TabIndex = 3;
            this.barHealth.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // pressEnter
            // 
            this.pressEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pressEnter.AutoSize = true;
            this.pressEnter.BackColor = System.Drawing.Color.Transparent;
            this.pressEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressEnter.ForeColor = System.Drawing.Color.White;
            this.pressEnter.Location = new System.Drawing.Point(545, 373);
            this.pressEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pressEnter.Name = "pressEnter";
            this.pressEnter.Size = new System.Drawing.Size(499, 110);
            this.pressEnter.TabIndex = 5;
            this.pressEnter.Text = "Press Enter to restart\r\nor ESC to Exit";
            this.pressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pressEnter.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::TopDownshooter.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(422, 470);
            this.player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(59, 87);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // txtBestScore
            // 
            this.txtBestScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBestScore.AutoSize = true;
            this.txtBestScore.BackColor = System.Drawing.Color.Transparent;
            this.txtBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestScore.ForeColor = System.Drawing.Color.White;
            this.txtBestScore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtBestScore.Location = new System.Drawing.Point(649, 31);
            this.txtBestScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBestScore.Name = "txtBestScore";
            this.txtBestScore.Size = new System.Drawing.Size(131, 24);
            this.txtBestScore.TabIndex = 6;
            this.txtBestScore.Text = "Best score: 0";
            this.txtBestScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::TopDownshooter.Properties.Resources.bggggg__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.txtBestScore);
            this.Controls.Add(this.pressEnter);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiirka Killer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.ProgressBar barHealth;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label pressEnter;
        private System.Windows.Forms.Label txtBestScore;
    }
}

