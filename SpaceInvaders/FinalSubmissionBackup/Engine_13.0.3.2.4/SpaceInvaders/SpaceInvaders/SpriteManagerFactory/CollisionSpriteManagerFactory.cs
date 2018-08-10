using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionSpriteManagerFactory
    {
        SpriteManager colManager;
        static CollisionSpriteManagerFactory colFactory = new CollisionSpriteManagerFactory();
        public CollisionSpriteManagerFactory()
        {
            colManager = new SpriteManager(RealSpriteCollisionFactory.colSprite);
        }
        public static CollisionSpriteManagerFactory instance
        {
            get
            {
                return colFactory;
            }
        }
        public SpriteManager getManager()
        {
            return colManager;
        }
        public void addCol(CollisionSprite col)
        {
            colManager.createActive(col);
        }
    }
}
