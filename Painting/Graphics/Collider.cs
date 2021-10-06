using GraphicsProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    public enum ColliderType
    {
        rect, ellipse, complex
    }
    public class Collider
    {
        public Rectangle bounds;
        public DrawableObject gameObject;
        public MovableObject movableObject;
        public ColliderType type;
        public double FlexCoef = 0.5;

        public Collider(ColliderType type, DrawableObject gameObject)
        {
            this.type = type;
            if (gameObject is MovableObject)
            {
                movableObject = gameObject as MovableObject;
            }
            else
                this.gameObject = gameObject;

            bounds = new Rectangle(gameObject.location, gameObject.size);
            World.collidersInWorld.Add(this);
        }
        public enum TouchTypes { top, bottom, left, right, unknown};
        public TouchTypes UpdateCollisions()
        {
            TouchTypes result = TouchTypes.unknown;
            this.bounds = new Rectangle(this.movableObject.location, this.movableObject.size);
            foreach(Collider other in World.collidersInWorld)
            {
                if (other.movableObject != null)
                    other.bounds = new Rectangle(other.movableObject.location, other.movableObject.size);
                else
                    other.bounds = new Rectangle(other.gameObject.location, other.gameObject.size);
                if (this != other)
                {
                    switch (this.type)
                    {
                        case ColliderType.rect:
                            {
                                switch(other.type)
                                {
                                    case ColliderType.rect:
                                        {
                                            Rectangle rect = new Rectangle(new Point(bounds.X + this.movableObject.speed.X, bounds.Y + this.movableObject.speed.Y), bounds.Size);
                                            if (rect.IntersectsWith(other.bounds))
                                            {
                                                if (rect.Y + rect.Height < other.bounds.Y + other.bounds.Height)
                                                { 
                                                    result = TouchTypes.top;
                                                    this.movableObject.speed.Y = -(int)(this.movableObject.speed.Y*FlexCoef);
                                                    return result;
                                                }
                                                if (other.bounds.Y  < rect.Y)
                                                { 
                                                    result = TouchTypes.bottom;
                                                    return result;
                                                }
                                                if (rect.X + rect.Width < other.bounds.X + other.bounds.Width)
                                                { 
                                                    result = TouchTypes.left;
                                                    this.movableObject.speed.X = -(int)(this.movableObject.speed.X * FlexCoef);// new Point(0, 0);
                                                    return result;
                                                }
                                                if (other.bounds.X < rect.X)
                                                { 
                                                    result = TouchTypes.right; 
                                                    this.movableObject.speed.X = -(int)(this.movableObject.speed.X * FlexCoef);
                                                    return result;
                                                }


                                                //if (this.movableObject is Player)
                                                {
                                                    
                                                }
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }
            }
            return result;
        }
    }
}
