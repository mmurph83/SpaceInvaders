using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class RealSpriteFactory
    {
        
        private static RealSpriteList list = new RealSpriteList();
        public static Sprite getSprite(SpriteType name)
        {
            Sprite temp = list.getSprite(name);
            if (temp == null)
            {
                temp = makeSprite(name);
                list.addRealSprite(temp);
            }
            return temp;
        }
        protected static Sprite makeSprite(SpriteType name)
        {

            return new Sprite(ImageList.list.getImage(name), TextureFactory.Texture_Factory().getTexture(name), SizeFactory.getFactory.baseS, name);

        }
    }
}
