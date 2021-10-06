using Graphics;
using System;
using System.Drawing;

namespace GraphicsProject
{
    public class MovableObject : DrawableObject
    {
        public Point speed;
        public DateTime FlyingStartTime;
        TimeSpan t;
        public bool Flying = false;
        public Point FlyingStartSpeed;
        public Collider.TouchTypes touch = Collider.TouchTypes.unknown;
        public MovableObject(Point location, Size size, Image image, Point speed) : base(location, size, image)
        {
            this.speed = speed;
        }
        public virtual void Move()
        {
            touch = collider.UpdateCollisions();
            if (Flying)
            {
                speed.Y = (int)(FlyingStartSpeed.Y + 9.8 * (DateTime.Now - FlyingStartTime).TotalSeconds);
            }
            location.X = location.X + speed.X;
            location.Y = location.Y + speed.Y;
        }
    }
}
