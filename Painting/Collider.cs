using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Painting.Form1;

namespace Painting
{
    public class Collider
    {
        public Rectangle bounds;
        public DrawableObject gameObject;
        public MovableObject movableObject;
        public ColliderType type;

        public enum ColliderType
        {
            rect, ellipse, complex
        }

        public Collider(ColliderType type, DrawableObject gameObject)
        {
            this.type = type;
            if(gameObject is MovableObject)
            {
                movableObject = gameObject as MovableObject;
            }
            else
            {
                this.gameObject = gameObject;
            }
            bounds = new Rectangle(gameObject.location, gameObject.size);
            World.collidersInWorld.Add(this);

        }
        public void UpdateCollisions()
        {
            this.bounds = new Rectangle(this.movableObject.location, this.movableObject.size);
            foreach(Collider other in World.collidersInWorld)
            {
                if(other.movableObject != null)
                {
                    other.bounds = new Rectangle(other.movableObject.location, other.movableObject.size);
                }
                else
                {
                    other.bounds = new Rectangle(other.gameObject.location, other.gameObject.size);
                }

                if (this != other)
                {
                    switch (type)
                    {
                        case ColliderType.rect:
                            {
                                switch (other.type)
                                {
                                    case ColliderType.rect:
                                        {
                                            if(new Rectangle(new Point(bounds.X + this.movableObject.speed.X,
                                                bounds.Y + this.movableObject.speed.X), bounds.Size).IntersectsWith(other.bounds))
                                            {
                                                this.movableObject.speed = new Point(0, 0);

                                                //if (this.movableObject is Player)
                                                //{
                                                //}
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }
            }
        }
    }
}
