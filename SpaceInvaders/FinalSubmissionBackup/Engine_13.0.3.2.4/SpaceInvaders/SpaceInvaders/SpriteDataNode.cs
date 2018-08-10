using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class SpriteDataNode :DLink
    {
        public SpriteType name;
        public SpriteBase sprite;
        public SpriteDataNode(SpriteBase sprite, SpriteType name)
        {
            this.name = name;
            this.sprite = sprite;
        }

    }
}
