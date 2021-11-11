using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDownshooter
{
    public partial class Form1 : Form
    {
        // Инициализация всех переменных
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int kills = 0;
        int playerHealth = 100;
        int speed = 14;
        int ammo = 10;
        int zombieSpeed = 4;
        int NUMZOMBIE = 8;
        static DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\sounds\\");
        public SoundPlayer sound_shoot = new SoundPlayer();
        public SoundPlayer sound_ammo = new SoundPlayer();
        public SoundPlayer sound_zombie_death = new SoundPlayer();
        public SoundPlayer sound_ambient = new SoundPlayer();

        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        
        public Form1()
        {
            InitializeComponent();
            sound_shoot.Open(info + @"shoot\shoot_1.wav", Program._devices[0]);
            sound_ammo.Open(info+ @"ammo\take_ammo.wav", Program._devices[0]);
            sound_zombie_death.Open(info + @"zombie\zombie_death.wav", Program._devices[0]);
            sound_ambient.Open(info + @"ambient\game_ambient_2.mp3", Program._devices[0]);
            sound_ambient.Volume = 30;
            RestartGame();

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            // Условие смерти и отображения здоровья
            if (playerHealth > 1)
                barHealth.Value = playerHealth;
            else
            {
                sound_ambient.Stop();
                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                gameOver = true;
                pressEnter.Visible = true;
                string filename = "TopScore.txt";
                int TopScore = Int32.Parse(File.ReadAllText(filename));
                txtBestScore.Text = $"Best score: {TopScore.ToString()}";
                if ( TopScore < kills)
                    File.WriteAllText(filename, kills.ToString());
            }

            // меняю цвет на красный если снарядов 0
            txtAmmo.Text = $"Ammo: {ammo}";
            if (ammo == 0)
                txtAmmo.ForeColor = Color.Red;
            else
                txtAmmo.ForeColor = Color.White;
            txtKills.Text = $"Kills: {kills}";

            // Логика движения игрока
            if (goLeft == true && player.Left > 0)
                player.Left -= speed;
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
                player.Left += speed;
            // чтобы игрок не залезал в статы сделал ограничитель
            if (goUp == true && player.Top > 33) 
                player.Top -= speed;
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
                player.Top += speed;

            // поднятие потронов
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ammo")
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        sound_ammo.Play();
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }

                // логика здоровья, что то в духе AI для зомбей
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                        playerHealth -= 1;

                    if(x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                // убийство зомбя
                foreach(Control j in this.Controls)
                    if (j is PictureBox && (string)j.Tag == "bullet" &&
                        x is PictureBox && (string)x.Tag == "zombie")
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            sound_zombie_death.Play();
                            kills++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();
                        }

            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver)
                return;

            // Картинки, направление, булевское значение движения
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
            // логика выстрела
            if (e.KeyCode == Keys.Space && ammo > 0 && !gameOver)
            {
                sound_shoot.Play();
                ammo--;
                ShootBullet(facing);
                if (ammo < 1)
                {
                    DropAmmo();
                    DropAmmo();
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (e.KeyCode == Keys.Up)
                goUp = false;
            if (e.KeyCode == Keys.Down)
                goDown = false;

            if (e.KeyCode == Keys.Enter && gameOver)
                RestartGame();
            if(e.KeyCode == Keys.Escape && gameOver)
            {
                Hide();
                Form0 fr0 = new Form0();
                fr0.ShowDialog();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // размещаю надпись о рестарте по центру
            pressEnter.Left = (Form1.ActiveForm.Width - pressEnter.Width) >> 1;
            pressEnter.Top = (Form1.ActiveForm.Height - pressEnter.Height) >> 1;
            txtKills.Left = (Form1.ActiveForm.Width - txtKills.Width) >> 1;
            // топ скор отображение
            int TopScore = Int32.Parse(File.ReadAllText("TopScore.txt"));
            txtBestScore.Text = $"Best score: {TopScore.ToString()}";
            sound_ambient.Play();
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 1920);
            zombie.Top = randNum.Next(0, 1080);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombie.BackColor = Color.Transparent;
            zombie.BringToFront();
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            //player.BringToFront();
        }
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(20, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            ammo.BackColor = Color.Transparent;
            this.Controls.Add(ammo);

            ammo.BringToFront();
            //player.BringToFront();
        }
        private void RestartGame()
        {
            pressEnter.Visible = false;
            player.Image = Properties.Resources.up;
            foreach (PictureBox i in zombiesList)
                this.Controls.Remove(i);

            zombiesList.Clear();

            for(int i = 0; i < NUMZOMBIE; i++)
                MakeZombies();

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;
            playerHealth = 100;
            kills = 0;
            ammo = 20;

            GameTimer.Start();
        }
    }
}
