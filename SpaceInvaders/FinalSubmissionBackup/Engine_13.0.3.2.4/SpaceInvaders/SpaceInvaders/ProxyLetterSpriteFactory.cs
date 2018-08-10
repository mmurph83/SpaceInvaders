using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProxyLetterSpriteFactory
    {
        static ProxyLetterSpriteFactory factory = new ProxyLetterSpriteFactory();
        SpriteManager manager;
        public ProxyLetterSpriteFactory()
        {
           manager = SpriteManagerFactory.createSpriteManager(SpriteType.Letter, 0);
        }
        public static ProxyLetterSpriteFactory getFactory()
        {
            return factory;
        }
        public ProxyLetterSprite createLetter(char c)
        {
            ProxyLetterSprite temp = new ProxyLetterSprite(SpriteType.Letter, ImageFactoryLetter.getFactory().getImage(c), RealSpriteFactory.getSprite(SpriteType.Letter));
            manager.createActive(temp);
            temp.setScale(SizeFactory.getFactory.letterScale.spriteWidth, SizeFactory.getFactory.letterScale.spriteHeight);
            return temp;
            
        }
    }
}
