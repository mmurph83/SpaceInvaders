using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class RealSpriteList : Manager
    {
        public RealSpriteList()
            : base(0)
        {

        }
        public void addRealSprite(Sprite sprite)
        {
            AddToActive(new RealSpriteData(sprite));
        }
        public Sprite getSprite(SpriteType name)
        {
            DLink temp = this.pActive;
            while (temp != null && ((RealSpriteData)temp).getName() != name)
            {
                temp = temp.pNext;
            }
            if (temp != null)
            {
                return ((RealSpriteData)temp).getSprite();
            }
            return null;
        }
    }
}
