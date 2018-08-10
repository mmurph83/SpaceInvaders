using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Sprite : SpriteBase
    {
        private Azul.Sprite sprite;
        
        
        public Sprite(Image image, Texture texture, Size size, SpriteType name)
        {
            this.sprite = new Azul.Sprite(texture.getTexture(), image.getRect(), size.getRect());
            this.name = name;
        }
        public Sprite(SpriteType name)
        {
            this.name = name;
        }
        public override void setSprite(SpriteBase sprite)
        {

        }
        
       
        public override void setTexture(Texture texture)
        {
            this.sprite.SwapTexture(texture.getTexture());
        }
        public override void setPosition(float x, float y)
        {
            this.sprite.x = x;
            this.sprite.y = y;
            
        }
        public override void setScale(float width, float height)
        {
            this.sprite.sx = width;
            this.sprite.sy = height;
        }
        public override void setColor(Color color)
        {
            this.sprite.SetColor( color.getColor());
        }
        public override void setImage(Image image)
        {
            this.sprite.SwapTextureRect(image.getRect());
        }
        public override void Update()
        {
            this.sprite.Update();
        }
        public override void Render()
        {
            this.sprite.Render();
        }
    }
}
