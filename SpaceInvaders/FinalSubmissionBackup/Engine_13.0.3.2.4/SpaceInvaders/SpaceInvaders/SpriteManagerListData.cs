using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class SpriteManagerListData : DLink
    {
        SpriteManager sManager;
        public SpriteManagerListData(SpriteManager sManager)
        {
            this.sManager = sManager;
        }
        public SpriteType getName()
        {
            return sManager.getName();
        }
        public void addProxySprite(Sprite sprite)
        {
            sManager.createActive(sprite);
        }
        public SpriteManager getSpriteManager() {
            return sManager;
        }
    }
}
