using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProxySprite : Sprite
    {
        SpriteBase realSprite;
        float x, y, width, height;
        Color color = ColorFactory.instance.w;
        public ProxySprite( SpriteType name, Sprite realSprite)
            : base(name)
        {
            this.realSprite = realSprite;
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
            this.realSprite.setImage(image);
        }
        public override void Update()
        {
            if (currentStatus == Status.Active)
            {
                this.realSprite.setPosition(x, y);
                this.realSprite.setScale(width, height);
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
