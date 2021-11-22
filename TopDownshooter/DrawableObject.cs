using System.Drawing;

namespace TopDownshooter
{
    class DrawableObject
    {
        public Point location;
        public Point StartLocation;
        public Size size;
        public Image image;
        public double coef = 1.5;
        public Animation animation = new Animation();
        public DrawableObject(Point location, Size size, Image image)
        {
            this.location = location;
            this.StartLocation = location;
            this.size = size;
            this.image = image;
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
        }
    }
}
