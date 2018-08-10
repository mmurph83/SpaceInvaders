using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public static class SpriteManagerFactory
    {
        static DLink spriteManagerList;
        public static SpriteManager createSpriteManager(SpriteType name, int numActive)
        {
            
            if (spriteManagerList == null)
            {
                spriteManagerList = new SpriteManagerListData(new SpriteManager(name));
                return ((SpriteManagerListData)spriteManagerList).getSpriteManager();
            }
            else
            {
                DLink temp = spriteManagerList;
                while (((SpriteManagerListData)temp).getName() != name && temp.pNext != null)
                {
                    temp = temp.pNext;
                }
                if (((SpriteManagerListData)temp).getName() != name)
                {
                    temp.pNext = new SpriteManagerListData(new SpriteManager(name));
                    temp = temp.pNext;
                }
                return ((SpriteManagerListData)temp).getSpriteManager();
            }
            
        }
    }
}
