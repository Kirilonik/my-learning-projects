using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace TopDownshooter
{
    class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;
        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            // параметры новой пули
            bullet.BackColor = Color.OrangeRed;
            bullet.Size = new Size(4, 8);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            // чтобы пуля была выше всех слоев
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            switch(direction)
            {
                case "left":
                    bullet.Left -= speed;
                    bullet.Size = new Size(8, 4);
                    break;
                case "right":
                    bullet.Left += speed;
                    bullet.Size = new Size(8, 4);
                    break;
                case "up":
                    bullet.Top -= speed;
                    break;
                case "down":
                    bullet.Top += speed;
                    break;
            }

            if(bullet.Left < 10 || bullet.Left > 1200 || bullet.Top < 10 || bullet.Top > 620)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}