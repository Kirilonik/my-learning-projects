using System.Drawing;
using static Painting.Collider;

namespace Painting
{
    public partial class Form1
    {
        public class DrawableObject
        {
            public Point location;
            public Collider collider;
            public Size size;
            public Image image;
            public double coef = 0.5;
            public Animation animation = new Animation();
            public Point StartLocation;

            public DrawableObject(Point location, Size size, Image image=null)
            {
                this.location = location;
                StartLocation = location;
                this.size = size;
                this.image = image;

                this.collider = new Collider(ColliderType.rect, this);
            }
            void UpdateLocations()
            {
                location.X = StartLocation.X + World.WorldShift;
            }
            public virtual void DrawImage(Graphics gr)
            {
                UpdateLocations();
                gr.DrawImage(animation.GetImage(), new Rectangle(location, size));
                gr.DrawRectangle(Pens.Blue, new Rectangle(location, size));
            }
        }
    }
}
