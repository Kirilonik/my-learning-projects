using Graphics;
using System;
using System.Drawing;

namespace GraphicsProject
{
    public class Player : MovableObject
    {
        string greeting;
        //Player player;
        public Player(Point location, Size size, Image image, Point speed, string greeting) : base(location, size, image, speed)
        {
            this.greeting = greeting;
        }
        public void DrawGreeting(System.Drawing.Graphics gr)
        {
            gr.DrawString(greeting, new Font("Arial", 10), Brushes.Black, new Point(location.X + size.Width + 10, location.Y - 10));
        }
        public override void Move()
        {
            touch = collider.UpdateCollisions();
            if (touch == Collider.TouchTypes.unknown)
            {
                if (!Flying)
                {
                    FlyingStartSpeed = new Point(speed.X, speed.Y);
                    FlyingStartTime = DateTime.Now;
                    Flying = true;
                }
            }
            else
            if (Flying)
            {
                Flying = false;
            }
            if (Flying)
            {
                speed.Y = (int)(FlyingStartSpeed.Y +
                    9.8 * (DateTime.Now -
                    FlyingStartTime).TotalSeconds);
            }

            //collider.UpdateCollisions();
            World.WorldShift.X += speed.X;
            World.WorldShift.Y += speed.Y;

        }
        public override void DrawImage(System.Drawing.Graphics gr)
        {
            Image current = animation.GetImage();
            gr.DrawImage(current, new Rectangle(new Point(location.X - (int)(current.Width * coef - size.Width) / 2, location.Y - (int)(current.Height * coef - size.Height)), new Size((int)(current.Width * coef), (int)(current.Height * coef))));
            gr.DrawRectangle(Pens.Black, new Rectangle(location, size));
        }
        public void AI()
        {

        }
    }
}
