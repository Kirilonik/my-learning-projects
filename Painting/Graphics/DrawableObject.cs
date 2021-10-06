using Graphics;
using System.Drawing;

namespace GraphicsProject
{
    public class DrawableObject
    {
        public Point location;
        public Collider collider;
        public Point StartLocation;
        public Size size;
        public Image image;
        public double coef = 1.5;
        public Animation animation = new Animation();
        public DrawableObject(Point location, Size size, Image image=null)
        {
            this.location = location;
            this.StartLocation = location;
            this.size = size;
            this.image = image;
            this.collider = new Collider(ColliderType.rect, this);
        }
        void UpdateLocation()
        {
            location.X = StartLocation.X - World.WorldShift.X;
            location.Y = StartLocation.Y - World.WorldShift.Y;

        }
        public virtual void DrawImage(System.Drawing.Graphics gr)
        {
            UpdateLocation();
            gr.DrawImage(animation.GetImage(), new Rectangle(location, size));
            gr.DrawRectangle(Pens.Blue, new Rectangle(location, size));
        }
    }
}
