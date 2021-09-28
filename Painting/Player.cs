using System.Drawing;

namespace Painting
{
    public partial class Form1
    {
        public class Player : MovableObject
        {
            string greeting;
            //Player player;
            public Player(Point location, Size size, Image image, Point speed, string greeting)
                : base(location, size, image, speed)
            {
                this.greeting = greeting;
            }
            public void DrawGreeting(Graphics gr)
            {
                gr.DrawString(greeting, new Font("Arial", 10), Brushes.Black,
                    new Point(location.X + size.Width + 10, location.Y - 10));
            }
            public override void Move()
            {
                World.WorldShift -= speed.X;
            }
            public override void DrawImage(Graphics gr)
            {
                Image current = animation.GetImage();
                gr.DrawImage(current, new Rectangle(
                    new Point(
                    location.X - (int)(current.Width * coef - size.Width)/2,
                    location.Y - (int)(current.Height*coef - size.Height)),
                    new Size(
                        (int)(current.Width*coef),
                        (int)(current.Height*coef)))
                    );
            }
            public void AI()
            {

            }
        }
    }
}
