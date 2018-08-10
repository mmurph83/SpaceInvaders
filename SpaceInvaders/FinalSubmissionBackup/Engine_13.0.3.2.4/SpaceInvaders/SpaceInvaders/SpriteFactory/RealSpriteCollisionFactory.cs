using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class RealSpriteCollisionFactory
    {
        public static CollisionSprite colSpriteVar = new CollisionSprite( SizeFactory.getFactory.baseS.getRect());
        
        public static CollisionSprite colSprite
        {
            get
            {
                return colSpriteVar;
            }
        }
    }
}
