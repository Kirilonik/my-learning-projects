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

namespace Threads_and_cicles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Cbitem item = new Cbitem(i*3, i*7);
                comboBox1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool move = false;
        Point delta;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            delta = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                pictureBox1.Location = new Point(e.X + pictureBox1.Location.X - delta.X, e.Y + pictureBox1.Location.Y - delta.Y);
                Size size = Form1.ActiveForm.Size;
                if(pictureBox1.Location.X < 0)
                {
                    pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                }
                if (pictureBox1.Location.Y < 0)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
                }
                if (pictureBox1.Location.X + pictureBox1.Size.Width > size.Width)
                {
                    pictureBox1.Location = new Point(size.Width - pictureBox1.Size.Width, pictureBox1.Location.Y);
                }
                if (pictureBox1.Location.Y + pictureBox1.Size.Height > size.Height)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, size.Height - pictureBox1.Size.Height);
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                pictureBox1.Location = new Point(e.X + pictureBox1.Location.X - delta.X, e.Y + pictureBox1.Location.Y - delta.Y);
                Size size = Form1.ActiveForm.Size;
                if (pictureBox1.Location.X < 0)
                {
                    pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                }
                if (pictureBox1.Location.Y < 0)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
                }
                if (pictureBox1.Location.X + pictureBox1.Size.Width > size.Width)
                {
                    pictureBox1.Location = new Point(size.Width - pictureBox1.Size.Width, pictureBox1.Location.Y);
                }
                if (pictureBox1.Location.Y + pictureBox1.Size.Height > size.Height)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, size.Height - pictureBox1.Size.Height);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        int add = -2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Width <= 10 || pictureBox1.Width >= 600)
                add = -add;

            if (pictureBox1.Width <= 10)
                pictureBox1.Width = 12;
            if (pictureBox1.Width >= 600)
                pictureBox1.Width = 598;

            pictureBox1.Width = pictureBox1.Width + add ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.Items[comboBox1.SelectedIndex].ToString(); // получить выбранные в выпадающем меню строку
            string s = comboBox1.SelectedItem.ToString();

            // проверка является ли выбранный элемент принадлежащим Cbitem
            Cbitem current;
            if(comboBox1.SelectedItem is Cbitem)
                current = comboBox1.SelectedItem as Cbitem;
            else
                current = new Cbitem(0, 0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            //textBox1.Text = comboBox1.SelectedItem.ToString();
        }
        // open
        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) // тут же и открываем окно для выбора файла
            {
                string data;
                string panth = openFileDialog1.FileName;
                using (StreamReader fin = new StreamReader(panth)) 
                {
                    data = fin.ReadToEnd();
                    textBox2.Text = data;
                }
            }
        }


        // save
        private void button3_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter fout = new StreamWriter(saveFileDialog1.FileName)) 
                {
                    fout.Write(textBox2.Text);
                }
                string json = "";
                using (StreamWriter fout = new StreamWriter(saveFileDialog1.FileName + ".json"))
                {
                    json = Newtonsoft.Json.JsonConvert.SerializeObject(comboBox1.Items, Newtonsoft.Json.Formatting.Indented);
                    fout.Write(json);
                    List<object> jsonread = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(json);
                    // добавил еще, что потом джон файл выводится на текстбокс1
                    string temp = "";
                    foreach (object item in jsonread)
                    {
                        temp += item.ToString();
                        temp += " ";
                    }
                    textBox2.Text = temp;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        // и еще сделать чтобы примагничивалось к панельке при наведении курсора достаточно близко к нему
        // сделать 2 прораммы которые обмениваются друг с другом даннми tcp вебсокеты какие то
      
    }

    public class Cbitem
    {
        public int f1;
        public int f2;

        public Cbitem(int f1, int f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }

        public override string ToString()
        {
            return f1.ToString() + " " + f2.ToString();
        }
    }
}
