using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDownshooter
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
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
    }
}
