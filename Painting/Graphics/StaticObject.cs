using GraphicsProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    public class StaticObject : DrawableObject
    {

        public StaticObject(Point location, Size size, Image image) : base(location, size, image)
        {
            animation.LoadSprites(Directory.GetDirectories(Animation.Path + "\\staticObject")[0], AnimationStates.idle);
        }
    }
}
