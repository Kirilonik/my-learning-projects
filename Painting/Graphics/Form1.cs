using Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsProject
{
   
    public partial class Form1 : Form
    {
        System.Drawing.Graphics graphics;
        BufferedGraphicsContext currentContext;
        BufferedGraphics myBuffer;
        Player npc1 = new Player(new Point(250, 70), new Size(150, 150), Image.FromFile("страж.png"), new Point(0, 0), "Когда-то и меня вела дорога приключений, но потом мне в колено попали стрелой");
        NPC npc2 = new NPC(new Point(800, 200), new Size(150, 150), Image.FromFile("страж.png"), new Point(0, 0), "Когда-то и меня вела дорога приключений, но потом мне в колено попали стрелой");
        StaticObject platform = new StaticObject(new Point(500, 200), new Size(100, 20), null);
        StaticObject platform1 = new StaticObject(new Point(0, 504 - 20), new Size(1085, 20), null);
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                npc1.speed.Y = -10;
                World.WorldShift.Y -= 1; //КОСТЫЛЬ
                npc1.Flying = true;
                npc1.FlyingStartSpeed = new Point(npc1.speed.X, npc1.speed.Y);
                npc1.FlyingStartTime = DateTime.Now;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (npc1.touch != Collider.TouchTypes.unknown)
                {
                    npc1.speed.X = 1;
                    npc1.animation.CurrentState = AnimationStates.walk;
                }

            }
            if (e.KeyCode == Keys.NumPad0)
            {
                npc1.coef += 0.1;
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                npc1.coef -= 0.1;
            }
            if (e.KeyCode == Keys.Left)
            {
                if (npc1.touch != Collider.TouchTypes.unknown)
                {
                    npc1.speed.X = -1;
                    npc1.animation.CurrentState = AnimationStates.walk;
                }
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
            Regex regex = new Regex("[а-яА-Я]+");
            if (regex.IsMatch("мама мыла раму"))
            {
                foreach (Match match in regex.Matches("мама мыла раму"))
                {
                    Console.WriteLine(match.Value);
                    Console.WriteLine(match.Groups[0]);

                }
            }


            Mammal m = new Mammal(20, 20, true);
            m.Smth();
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(panel1.CreateGraphics(),
               panel1.DisplayRectangle);
            graphics = myBuffer.Graphics;
            foreach (var folder in Directory.GetDirectories(Animation.Path + "\\npc"))
            {
                npc1.animation.LoadSprites(folder, Animation.StringToState[folder.Split('\\').Last<string>()]);
            }
            foreach (var folder in Directory.GetDirectories(Animation.Path + "\\npc"))
            {
                npc2.animation.LoadSprites(folder, Animation.StringToState[folder.Split('\\').Last<string>()]);
            }
        }
        Image test = Image.FromFile(@"Panda-sleep-on-ground_2880x1800.jpg");
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(panel1.BackColor);
            graphics.DrawImage(test, 0,0, this.Width, this.Height);
            graphics.DrawLine(new Pen(Color.FromArgb(132, 132, 0)), new Point(0, 0), new Point(50, 50));
            graphics.DrawEllipse(Pens.BlueViolet, new Rectangle(50, 50, 50, 50));
            graphics.DrawString("test", new Font("Arial", 20), Brushes.Black, new Point(50, 60));
            //graphics.DrawImage(test, new Rectangle(60, 60, (int)(test.Width * 0.1), (int)(test.Height * 0.1)));
            //graphics.DrawImage(test, new Rectangle(60, 60, (int)(test.Width * 0.1), (int)(test.Height * 0.1)), new Rectangle(0, 0, test.Width / 2, test.Height / 2), GraphicsUnit.Pixel);
            npc1.Move();
            npc1.DrawImage(graphics);
            npc1.DrawGreeting(graphics);
            npc2.Move();
            npc2.DrawImage(graphics);
            npc2.DrawGreeting(graphics);
            platform.DrawImage(graphics);
            platform1.DrawImage(graphics);

            myBuffer.Render();
        }
    }
    public class Animal
    {
        int size;
        int age;

        public Animal(int size, int age)
        {
            this.size = size;
            this.age = age;
        }

        public virtual void Smth()
        { }
    }
    public class Mammal : Animal
    {
        bool milk;

        public Mammal(int size, int age, bool milk)
            : base(size, age)
        {
            this.milk = milk;
        }
        public void Smth()
        {

        }
    }
}
