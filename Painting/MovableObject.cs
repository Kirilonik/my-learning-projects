using System.Drawing;

namespace Painting
{
    public partial class Form1
    {
        public class MovableObject : DrawableObject
        {
            public Point speed;
            public MovableObject(Point location, Size size, Image image, Point speed)
                : base(location, size, image)
            {
                this.speed = speed;
            }
            public virtual void Move()
            {
                collider.UpdateCollisions();
                location.X = location.X + speed.X;
                location.Y = location.Y + speed.Y;
            }
        }
    }
}
