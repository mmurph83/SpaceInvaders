using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProxyCollisionSprite : CollisionSprite
    {
        CollisionSprite collisionBox;
        float x = 1;
        float y = 1;
        float width = 1;
        float height = 1;
        Color color = ColorFactory.instance.b;
        public ProxyCollisionSprite(CollisionSprite sprite)
        {
            this.collisionBox = sprite;
            setScale(1,1 );
            //collisionBox = new Azul.SpriteBox(new Azul.Rect(0f, 0f, 0f, 0f), new Azul.Color(1.0f, 1.0f, 1.0f, 1.0f));
           
        }
        
        public override void setTransformation(float x,float y,float width,float height)
        {
            this.setPosition(x, y);
            this.setScale(width, height);
        }
        public override void setPosition(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override void setScale(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override void Update()
        {
            if (currentStatus == Status.Active)
            {
                this.collisionBox.setTransformation(x, y, width, height);
                this.collisionBox.setColor(color);
                this.collisionBox.Update();
                this.collisionBox.Render();
            }
        }
        public override void setColor(Color color)
        {
            this.color = color;
        }
        public override void Render()
        {
            //this.sprite.Render();
        }
        public override float getPosX()
        {
            return x;
        }
        public override float getPosY()
        {
            return y;
        }
        public override float getWidth()
        {
            return width;
        }
        public override float getHeight()
        {
            return height;
        }
    }
}
