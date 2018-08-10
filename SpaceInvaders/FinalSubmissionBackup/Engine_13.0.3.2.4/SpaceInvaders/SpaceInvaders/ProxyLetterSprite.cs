using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProxyLetterSprite :Sprite
    {
        SpriteBase realSprite;
        float x, y, width, height;
        Color color = ColorFactory.instance.w;
        Image image;
        public ProxyLetterSprite( SpriteType name,Image image, Sprite realSprite)
            : base(name)
        {
            this.realSprite = realSprite;
            this.image = image;
            setScale(1, 1);
        }
        public override void setTexture(Texture texture)
        {
            this.realSprite.setTexture(texture);
        }
        public override void setPosition(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override void setSprite(SpriteBase sprite)
        {
            this.realSprite = sprite;
        }
        public override void setScale(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override void setColor(Color color)
        {
            this.realSprite.setColor(color);
        }
        public override void setImage(Image image)
        {
            this.image = image;
        }
        public override float getWidth()
        {
            return width;
        }
        public override float getHeight()
        {
            return height;
        }
        public override void Update()
        {
            if (currentStatus == Status.Active)
            {
                this.realSprite.setPosition(x, y);
                this.realSprite.setScale(width, height);
                this.realSprite.setImage(image);
                this.realSprite.Update();
                this.realSprite.Render();
               
            }
        }
        public override void Render()
        {
            //this.sprite.Render();
        }
    }
}
