using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        NPC npc1 = new NPC(new Point(170, 70), new Size(50, 50),
            Image.FromFile("example-23514.jpg"), new Point(0, 1),
            "Когда-то меня тоже вела дорога приключений,\n но потом мне прострелили колено.");

        public Form1()
        {
            InitializeComponent();
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate
                (panel1.CreateGraphics(), panel1.DisplayRectangle);

            // создание некоторого холста.
            graphics = myBuffer.Graphics;
            
        }


        Image test = Image.FromFile("sdf.jpg");

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(panel1.BackColor);
            graphics.DrawLine(new Pen(Color.FromArgb(132,132,0)), new Point(0,0), new Point(50,50));
            graphics.DrawEllipse(Pens.BlueViolet, new Rectangle(50, 50, 50, 50));
            graphics.DrawString("Hello, World", new Font("Arial", 20), Brushes.Black, new Point(50,200));

            graphics.DrawImage(test, new Rectangle(120,60, (int)(test.Width*0.2), (int)(test.Height*0.2)));
            npc1.Move();
            npc1.DrawImage(graphics);
            npc1.DrawGreeting(graphics);

            myBuffer.Render();
        }

        public class DrawableObject
        {
            public Point location;
            public Size size;
            public Image image;

            public DrawableObject(Point location, Size size, Image image)
            {
                this.location = location;
                this.size = size;
                this.image = image;
            }
            public void DrawImage(Graphics gr)
            {
                gr.DrawImage(image, new Rectangle(location, size));
            }
        }
        public class MovableObject : DrawableObject
        {
            public Point speed;
            public MovableObject(Point location, Size size, Image image, Point speed)
                : base(location, size, image)
            {
                this.speed = speed;
            }
            public void Move()
            {
                location.X = location.X + speed.X;
                location.Y = location.Y + speed.Y;
            }
        }
        public class NPC : MovableObject
        {
            string greeting;
            public NPC(Point location, Size size, Image image, Point speed, string greeting)
                : base(location, size, image, speed)
            {
                this.greeting = greeting;
            }
            public void DrawGreeting(Graphics gr)
            {
                gr.DrawString(greeting, new Font("Arial", 10), Brushes.Black,
                    new Point(location.X + size.Width + 10, location.Y - 10));
            }
        }
    }
}
