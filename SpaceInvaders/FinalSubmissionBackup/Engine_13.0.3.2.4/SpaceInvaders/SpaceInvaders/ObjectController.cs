using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ObjectController : Visitor
    {
        protected GameObject gameObject;
        
        public ObjectController(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }

        public void setCollisionSprite(CollisionSprite collisionSprite)
        {
            this.gameObject.setCollisionSprite(collisionSprite);
        }
        /*public GameObject(Sprite sprite)
        {
            this.sprite = sprite;
        }*/
        public void setSprite(Sprite sprite)
        {
            this.gameObject.setSprite(sprite);
        }
        public void swapSprite(Sprite sprite)
        {
            this.gameObject.swapSprite(sprite);
        }
        public virtual void setPos(float x, float y)
        {
            this.gameObject.setPos(x, y);
        }
        public virtual void translate(float xOffset, float yOffset)
        {
            this.setPos(gameObject.getPosX() + xOffset, gameObject.getPosY() + yOffset);
        }
        public float getPosX()
        {
            return this.gameObject.getPosX();
        }
        public float getPosY()
        {
            return this.gameObject.getPosY();
        }
        
        public virtual CollisionSprite getCollisionComponent()
        {
            return this.gameObject.getCollisionComponent();
        }
        public Status getStatus()
        {
            return gameObject.getStatus();
        }
        public virtual void setStatus(Status status)
        {

        }
        public virtual void notifyHit(){

        }
        public void setColScale(float x, float y)
        {
            gameObject.setColScale(x, y);
        }
        public void setSpriteScale(float x, float y)
        {
            gameObject.setScale(x, y);
        }
        public virtual void perform()
        {

        }
    }
}
