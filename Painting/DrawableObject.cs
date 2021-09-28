using System.Drawing;

namespace Painting
{
    public partial class Form1
    {
        public class DrawableObject
        {
            public Point location;
            public Size size;
            public Image image;
            public double coef = 0.5;
            public Animation animation = new Animation();
            public Point StartLocation;

            public DrawableObject(Point location, Size size, Image image)
            {
                this.location = location;
                StartLocation = location;
                this.size = size;
                this.image = image;
            }
            void UpdateLocations()
            {
                location.X = StartLocation.X + World.WorldShift;
            }
            public virtual void DrawImage(Graphics gr)
            {
                UpdateLocations();
                gr.DrawImage(animation.GetImage(), new Rectangle(location, size));
            }
        }
    }
}
