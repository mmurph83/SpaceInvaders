using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProjectileFactory
    {
        SpriteManager spriteManager = SpriteManagerFactory.createSpriteManager(SpriteType.Projectile,0);
        static ProjectileFactory factory = new ProjectileFactory();
        public static ProjectileFactory Instance
        {
            get
            {
                return factory;
            }
        }
        public Projectile createPlayerProjectile()
        {
            GameObject temp = GameObjectFactory.createGameObject();
            ProxyCollisionSprite t = ProxySpriteCollisionFactory.proxy;
            t.setScale(SizeFactory.getFactory.playerP.colWidth, SizeFactory.getFactory.playerP.colHeight);
            temp.setCollisionSprite(t);
            Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.PlayerProjectile);
            temp.setSprite(s);
            spriteManager.createActive(s);
            temp.setScale(SizeFactory.getFactory.playerP.spriteWidth, SizeFactory.getFactory.playerP.spriteHeight);
            return new Projectile(temp, MovementStateFactory.up);
        }
        public Projectile createEnemyProjectile()
        {
            GameObject temp = GameObjectFactory.createGameObject();
            CollisionSprite sprite = ProxySpriteCollisionFactory.proxy;
            sprite.setScale(SizeFactory.getFactory.enemyP.colWidth, SizeFactory.getFactory.enemyP.colHeight);
            Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.EnemyProjectile);
            s.setScale(SizeFactory.getFactory.enemyP.spriteWidth, SizeFactory.getFactory.enemyP.spriteHeight);
            temp.setCollisionSprite(sprite);
            spriteManager.createActive(s);
            temp.setSprite(s);
            
            return new Projectile(temp, MovementStateFactory.down);
        }
        public Projectile editEnemyProjectile(Projectile projectile)
        {
            projectile.swapSprite(RealSpriteFactory.getSprite(SpriteType.EnemyProjectile));
            return projectile;
        }
    }
}
