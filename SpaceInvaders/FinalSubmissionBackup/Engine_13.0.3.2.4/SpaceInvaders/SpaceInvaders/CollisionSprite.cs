using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionSprite : SpriteBase
    {
        Azul.SpriteBox collisionBox;
        
        public CollisionSprite()
        {
            //collisionBox = new Azul.SpriteBox(new Azul.Rect(0f, 0f, 0f, 0f), new Azul.Color(1.0f, 1.0f, 1.0f, 1.0f));
        }
        public CollisionSprite(Azul.Rect rect)
        {
            collisionBox = new Azul.SpriteBox(rect, ColorFactory.instance.w.getColor());
        }
        public override void setTransformation(float x,float y,float width,float height)
        {
            this.setPosition(x, y);
            this.setScale(width, height);
        }
        public override void setPosition(float x, float y)
        {
            collisionBox.x = x;
            collisionBox.y = y;
        }
        public override void setColor(Color color)
        {
            collisionBox.SetColor(color.getColor());
        }
        public override void setScale(float width, float height)
        {
            collisionBox.sx = width;
            collisionBox.sy = height;
        }
        public override void Update()
        {
            collisionBox.Update();
        }
        public override void Render()
        {
            collisionBox.Render();
        }
        public override float getPosX()
        {
            return collisionBox.x;
        }
        public override float getPosY()
        {
            return collisionBox.y;
        }
        public override float getWidth()
        {
            return collisionBox.sx;
        }
        public override float getHeight()
        {
            return collisionBox.sy;
        }
        public bool checkCollision(CollisionSprite s1, CollisionSprite s2)
        {
            
            if (s1.getPosX() - (s1.getWidth() / 2) < s2.getPosX() + (s2.getWidth() / 2) && s1.getPosX() + (s1.getWidth() / 2) > s2.getPosX() - (s2.getWidth() / 2) )
            {
                if (s1.getPosY() - (s1.getHeight() / 2) < s2.getPosY() + (s2.getHeight() / 2) && s1.getPosY() + (s1.getHeight() / 2) > s2.getPosY() - (s2.getHeight() / 2))
                {
                    return true;
                }
            }
            return false;
        }

        public override bool visitGrid(CollisionSprite visitor)
        {
            return checkCollision(this, visitor);
        }
    }
}
