using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TopDownshooter
{
    public partial class Form0 : Form
    {
        static DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\sounds\\");
        public System.Media.SoundPlayer sound_ambient = new System.Media.SoundPlayer(info.FullName + "ambient\\ambient_1.wav");

        public Form0()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sound_ambient.Stop();
            Hide();
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Enter)
                label1_Click(sender, e);
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            sound_ambient.PlayLooping();
        }
    }
}
