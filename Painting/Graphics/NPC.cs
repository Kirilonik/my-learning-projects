using Graphics;
using System.Drawing;

namespace GraphicsProject
{
    public class NPC : MovableObject
    {
        string greeting;
        //NPC NPC;
        public NPC(Point location, Size size, Image image, Point speed, string greeting) : base(location, size, image, speed)
        {
            this.greeting = greeting;
        }
        public void DrawGreeting(System.Drawing.Graphics gr)
        {
            gr.DrawString(greeting, new Font("Arial", 10), Brushes.Black, new Point(location.X + size.Width+10, location.Y-10 ));
        }
       
        
        public void AI()
        {

        }
    }
}
