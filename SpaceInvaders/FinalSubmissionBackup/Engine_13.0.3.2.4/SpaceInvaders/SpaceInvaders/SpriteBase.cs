using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public abstract class SpriteBase : Visitor
    {
        protected SpriteType name;
        protected Status currentStatus = Status.Active;
        public SpriteBase(){

        }
        public virtual void setSprite(SpriteBase sprite)
        {

        }
        public SpriteType getName()
        {
            return name;
        }
        public virtual void setTexture(Texture texture)
        {

        }
        public virtual void setImage(Image image)
        {

        }
        public virtual void setTransformation(float x, float y, float width, float height)
        {
            
        }
        public virtual void setPosition(float x, float y)
        {
            
            
        }
        public virtual void setScale(float width, float height)
        {
            
        }
        public virtual void setColor(Color color)
        {
            
        }
        
        public virtual void Update()
        {
            
        }
        public virtual void Render()
        {
            
        }
        public virtual float getPosX()
        {
            return 0;
        }
        public virtual float getPosY()
        {
            return 0;
        }
        public virtual float getWidth()
        {
            return 0;
        }
        public virtual float getHeight()
        {
            return 0;
        }
        public virtual void setStatus(Status status)
        {
            this.currentStatus = status;
        }
        public virtual Status getStatus()
        {
            return currentStatus;
        }
    }
}
