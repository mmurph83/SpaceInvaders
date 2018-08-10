using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionSpawnFactory
    {
        static CollisionSpawnFactory factory = new CollisionSpawnFactory();
        DLink head;
        public static CollisionSpawnFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public void spawnExplosion(float x, float y)
        {
           
                DLink temp = head;
                while (temp != null && ((ExplosionSpriteData)temp).checkStatus() == Status.Active)
                {
                    temp = temp.pNext;
                }
                if (temp != null) {
                    ((ExplosionSpriteData)temp).setPos(x, y);
                    ((ExplosionSpriteData)temp).setStatus(Status.Active);
                    ((ExplosionSpriteData)temp).addToReceiver();
                }
                else
                {
                    createNewExplosion(x, y);
                }

        }
        public void setAllInactive()
        {
            DLink temp = head;
            while (temp != null )
            {
                ((ExplosionSpriteData)temp).setStatus(Status.Inactive);
                temp = temp.pNext;
            }
        }
        void createNewExplosion(float x, float y)
        {
            if (head == null)
            {
                head = new ExplosionSpriteData(new CollisionRenderCommand(ProxyExplosionSpriteFactory.getFactory.createExplosion()));
                ((ExplosionSpriteData)head).setPos(x, y);
                ((ExplosionSpriteData)head).setStatus(Status.Active);
                ((ExplosionSpriteData)head).addToReceiver();
            }
            else
            {
                DLink temp = new ExplosionSpriteData(new CollisionRenderCommand(ProxyExplosionSpriteFactory.getFactory.createExplosion()));
                ((ExplosionSpriteData)temp).setPos(x, y);
                ((ExplosionSpriteData)temp).setStatus(Status.Active);
                ((ExplosionSpriteData)temp).addToReceiver();

                temp.pNext = head;
                head = temp;
            }
        }
    }
}
