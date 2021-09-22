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
            public Animation animation = new Animation();

            public DrawableObject(Point location, Size size, Image image)
            {
                this.location = location;
                this.size = size;
                this.image = image;
            }
            public void DrawImage(Graphics gr)
            {
                gr.DrawImage(animation.GetImage(), new Rectangle(location, size));
            }
        }
    }
}
