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

        Player npc1 = new Player(new Point(220, 240), new Size(50, 50),
            Image.FromFile("example-23514.jpg"), new Point(0, 0),
            "Когда-то меня тоже вела дорога приключений,\n но потом мне прострелили колено.");

        NPC npc2 = new NPC(new Point(100, 250), new Size(50, 50),
            Image.FromFile("example-23514.jpg"), new Point(0, 0),
            " ");

        StaticObject platform = new StaticObject(new Point(300, 280), new Size(50, 100), null);

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad3)
            {
                npc1.coef -= 0.01;
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                npc1.coef += 0.01;
            }

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
            if(e.KeyCode == Keys.Up)
            {
                npc1.speed.Y = -1;
                npc1.animation.CurrentState = AnimationStates.walk;
            }
            if(e.KeyCode == Keys.Down)
            {
                npc1.speed.Y = 1;
                npc1.animation.CurrentState = AnimationStates.walk;
            }
        }
        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                npc1.speed.X = 0;
                npc1.speed.Y = 0;
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
            foreach (var folder in Directory.GetDirectories(Animation.Path + "\\npc"))
            {
                npc2.animation.LoadSprites(folder,
                    Animation.StringToState[folder.Split('\\').Last<string>()]);
            }

        }


        Image test = Image.FromFile(@"ppp.jpg");

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(panel1.BackColor);
            graphics.DrawImage(test, 0, 0, this.Width, this.Height);
            //graphics.DrawLine(new Pen(Color.FromArgb(132,132,0)), new Point(0,0), new Point(50,50));
            //graphics.DrawEllipse(Pens.BlueViolet, new Rectangle(50, 50, 50, 50));
            //graphics.DrawString("Hello, World", new Font("Arial", 20), Brushes.Black, new Point(50,200));

            //graphics.DrawImage(test, new Rectangle(120,60, (int)(test.Width*0.3), (int)(test.Height*0.3)));
            npc1.Move();
            npc1.DrawImage(graphics);
            npc1.DrawGreeting(graphics);
            npc2.Move();
            npc2.DrawImage(graphics);
            npc2.DrawGreeting(graphics);
            platform.DrawImage(graphics);

            myBuffer.Render();
        }
    }
}
