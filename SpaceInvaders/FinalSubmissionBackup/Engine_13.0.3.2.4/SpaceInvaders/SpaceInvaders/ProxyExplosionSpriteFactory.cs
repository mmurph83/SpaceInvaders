using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProxyExplosionSpriteFactory
    {
        SpriteManager manager;
        Sprite sprite;
        static ProxyExplosionSpriteFactory factory = new ProxyExplosionSpriteFactory();
        public ProxyExplosionSpriteFactory()
        {
            manager = SpriteManagerFactory.createSpriteManager(SpriteType.Explosion, 0);
            sprite = RealSpriteFactory.getSprite(SpriteType.Explosion);
            sprite.setScale(SizeFactory.getFactory.alienScale.spriteWidth, SizeFactory.getFactory.alienScale.spriteHeight);
        }
        public static ProxyExplosionSpriteFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public Sprite createExplosion()
        {
            Sprite temp =  new ProxySprite(SpriteType.Explosion, RealSpriteFactory.getSprite(SpriteType.Explosion));
            temp.setSprite(sprite);
            manager.createActive(temp);
            temp.setScale(SizeFactory.getFactory.alienScale.spriteWidth, SizeFactory.getFactory.alienScale.spriteHeight);
            return temp;
        }
    }
}
