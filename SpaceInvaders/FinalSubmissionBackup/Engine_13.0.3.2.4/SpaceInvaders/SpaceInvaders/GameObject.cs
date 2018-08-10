using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameObject
    {
        float x = -100;
        float y = -100;
        Sprite sprite;
        CollisionSprite collisionSprite;
        Status objectStatus = Status.Active;
        public GameObject()
        {

        }

        public void setCollisionSprite(CollisionSprite collisionSprite)
        {
            this.collisionSprite = collisionSprite;
        }
        /*public GameObject(Sprite sprite)
        {
            this.sprite = sprite;
        }*/
        public void setSprite(Sprite sprite)
        {
            this.sprite = sprite;
            
        }
        public void swapSprite(Sprite sprite)
        {
            this.sprite.setSprite(sprite);
        }
        public void setPos(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.UpdatePos();
        }
        public void UpdatePos()
        {
            sprite.setPosition(x, y);
            collisionSprite.setPosition(x, y);
        }
        public float getPosX()
        {
            return this.x;
        }
        public float getPosY()
        {
            return this.y;
        }
        public void setColScale(float x, float y)
        {
            collisionSprite.setScale(x, y);
        }
        public void setScale(float x, float y)
        {
            sprite.setScale(x, y);
        }
        public virtual CollisionSprite getCollisionComponent()
        {
            return collisionSprite;
        }
        public Status getStatus()
        {
            return objectStatus;
        }
        public void setStatus(Status status)
        {
            this.objectStatus = status;
            sprite.setStatus(status);
            collisionSprite.setStatus(status);
        }
    }
}
