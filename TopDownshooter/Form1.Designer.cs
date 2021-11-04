
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.barHealth = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(12, 9);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(114, 29);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtKills
            // 
            this.txtKills.AutoSize = true;
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.ForeColor = System.Drawing.Color.White;
            this.txtKills.Location = new System.Drawing.Point(600, 9);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(92, 29);
            this.txtKills.TabIndex = 1;
            this.txtKills.Text = "Kills: 0";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(1003, 10);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(95, 29);
            this.Health.TabIndex = 2;
            this.Health.Text = "Health ";
            this.Health.Click += new System.EventHandler(this.Health_Click);
            // 
            // barHealth
            // 
            this.barHealth.Location = new System.Drawing.Point(1095, 12);
            this.barHealth.Name = "barHealth";
            this.barHealth.Size = new System.Drawing.Size(155, 26);
            this.barHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHealth.TabIndex = 3;
            this.barHealth.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtAmmo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kiirka Killer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.ProgressBar barHealth;
    }
}

