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

        private void startGame_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
            Close();
        }
    }
}
