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

namespace Painting
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        BufferedGraphics myBuffer;
        BufferedGraphicsContext currentContext;

        NPC npc1 = new NPC(new Point(170, 240), new Size(50, 50),
            Image.FromFile("example-23514.jpg"), new Point(0, 0),
            "Когда-то меня тоже вела дорога приключений,\n но потом мне прострелили колено.");

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                npc1.speed.X = 1;
                npc1.animation.CurrentState = AnimationStates.walk;
            }
            if (e.KeyCode == Keys.Left)
            {
                npc1.speed.X = -1;
                npc1.animation.CurrentState = AnimationStates.walk;
            }
        }
        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                npc1.speed.X = 0;
                npc1.animation.CurrentState = AnimationStates.idle;
            }

        }

        public Form1()
        {
            InitializeComponent();
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate
                (panel1.CreateGraphics(), panel1.DisplayRectangle);

            // создание некоторого холста.
            graphics = myBuffer.Graphics;

            foreach(var folder in Directory.GetDirectories(Animation.Path + "\\npc"))
            {
                npc1.animation.LoadSprites(folder,
                    Animation.StringToState[folder.Split('\\').Last<string>()]);
            }
            
        }


        Image test = Image.FromFile("sdf.jpg");

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(panel1.BackColor);
            graphics.DrawLine(new Pen(Color.FromArgb(132,132,0)), new Point(0,0), new Point(50,50));
            graphics.DrawEllipse(Pens.BlueViolet, new Rectangle(50, 50, 50, 50));
            graphics.DrawString("Hello, World", new Font("Arial", 20), Brushes.Black, new Point(50,200));

            graphics.DrawImage(test, new Rectangle(120,60, (int)(test.Width*0.3), (int)(test.Height*0.3)));
            npc1.Move();
            npc1.DrawImage(graphics);
            npc1.DrawGreeting(graphics);

            myBuffer.Render();
        }
    }
}
