using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProxySpriteCollisionFactory
    {
        static SpriteManager proxyCollision = CollisionSpriteManagerFactory.instance.getManager();
        static ProxySpriteCollisionFactory colFactory = new ProxySpriteCollisionFactory();
        public ProxySpriteCollisionFactory()
        {
            proxyCollision = CollisionSpriteManagerFactory.instance.getManager();
        }
        public static ProxySpriteCollisionFactory instance
        {
            get
            {
                return colFactory;
            }
        }
        static ProxyCollisionSprite addSprite()
        {
            ProxyCollisionSprite temp = new ProxyCollisionSprite(RealSpriteCollisionFactory.colSprite);
            proxyCollision.createActive(temp);
            return temp;
        }
        public void setRender()
        {
            proxyCollision.setRender();
        }
        public static ProxyCollisionSprite proxy
        {
            get
            {
                
                return addSprite();
            }
        }
    }
}
