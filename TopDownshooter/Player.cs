using System.Drawing;

namespace TopDownshooter
{
    class Player : MovableObject
    {
        //Player player;
        public Player(Point location, Size size, Image image, Point speed) : base(location, size, image, speed)
        {

        }
        public override void Move()
        {
            World.WorldShift += speed.X;
        }
        public override void DrawImage(System.Drawing.Graphics gr)
        {
            Image current = animation.GetImage();
            gr.DrawImage(current, new Rectangle(new Point(location.X - (int)(current.Width * coef - size.Width) / 2,
                location.Y - (int)(current.Height * coef - size.Height)), new Size((int)(current.Width * coef),
                (int)(current.Height * coef))));
            gr.DrawRectangle(Pens.Black, new Rectangle(location, size));
        }
    }
}
