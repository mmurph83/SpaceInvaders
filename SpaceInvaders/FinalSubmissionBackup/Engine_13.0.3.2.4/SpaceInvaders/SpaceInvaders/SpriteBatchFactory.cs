using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class SpriteBatchFactory
    {
        SpriteBatchRenderer renderer = new SpriteBatchRenderer();
        static SpriteBatchFactory factory = new SpriteBatchFactory();
        public SpriteBatchFactory()
        {
            renderer.createActive(CollisionSpriteManagerFactory.instance.getManager());
            renderer.createActive(SpriteManagerFactory.createSpriteManager(SpriteType.Explosion, 0));
            renderer.createActive(SpriteManagerFactory.createSpriteManager(SpriteType.Alien, 0));
            renderer.createActive(SpriteManagerFactory.createSpriteManager(SpriteType.Player, 0));
            renderer.createActive(SpriteManagerFactory.createSpriteManager(SpriteType.Projectile, 0));
            renderer.createActive(SpriteManagerFactory.createSpriteManager(SpriteType.Shield, 0));
            renderer.createActive(SpriteManagerFactory.createSpriteManager(SpriteType.Letter, 0));
            //renderer.createActive(CollisionSpriteManagerFactory.instance.getManager());
        }
        public static SpriteBatchFactory instance
        {
            get
            {
                return factory;
            }
        }
        public void render()
        {
            renderer.Update();
        }
    }
}
