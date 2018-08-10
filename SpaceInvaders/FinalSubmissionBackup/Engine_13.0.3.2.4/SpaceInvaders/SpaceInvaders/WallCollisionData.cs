using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class WallCollisionData :CLink
    {
        CollisionSprite wall;
        SpriteType name = SpriteType.Wall;
        public WallCollisionData(CollisionSprite wall)
        {
            this.wall = wall;
        }
        public CollisionSprite getCol()
        {
            return wall;
        }
        public SpriteType getName()
        {
            return name;
        }
    }
}
