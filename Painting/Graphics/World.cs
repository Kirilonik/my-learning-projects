using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    public class World
    {
        public static Point WorldShift = Point.Empty;
        public static List<Collider> collidersInWorld = new List<Collider>();
    }
}
