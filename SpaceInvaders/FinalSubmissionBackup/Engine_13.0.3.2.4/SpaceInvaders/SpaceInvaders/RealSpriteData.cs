using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class RealSpriteData : DLink
    {
        Sprite sprite;
        public RealSpriteData(Sprite sprite)
        {
            this.sprite = sprite;
        }
        public SpriteType getName()
        {
            return sprite.getName();
        }
        public Sprite getSprite()
        {
            return sprite;
        }
    }
}
