using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Visitable
    {
        public virtual bool acceptGridVisit(CollisionSprite visitor)
        {
            return false;
        }
        public virtual ObjectController acceptGameObjectVisit(CollisionSprite visitor)
        {
            return null;
        }
        public virtual bool acceptGameObjectTreeVisit(GameObjectTree gTree)
        {
            return false;
        }
        public virtual void acceptGridCollisionSubject(AlienGridCollisionSubject subject)
        {

        }
        public virtual void accpetPlayerCollision(Player player)
        {

        }
        public virtual void acceptProjectileController(ProjectileController projectileController)
        {

        }
    }
}
