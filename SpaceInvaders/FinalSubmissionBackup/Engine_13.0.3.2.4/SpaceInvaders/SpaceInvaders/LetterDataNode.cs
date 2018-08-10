using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class LetterDataNode :DLink
    {
        Sprite sprite;
        char c;
        int num = 0;
        public LetterDataNode(ProxyLetterSprite sprite, int num)
        {
            this.sprite = sprite;
            this.c = '0';
            this.num = num;
        }
        public Sprite getSprite()
        {
            return sprite;
        }
        public char getLetter()
        {
            return c;
        }
        public void setImage(Image image)
        {
            this.sprite.setImage(image);
        }
        public void setPos(float x, float y)
        {
            this.sprite.setPosition(x, y);
        }
        public void setScale(float width, float height)
        {
            this.sprite.setScale(width, height);
        }
    }
}
