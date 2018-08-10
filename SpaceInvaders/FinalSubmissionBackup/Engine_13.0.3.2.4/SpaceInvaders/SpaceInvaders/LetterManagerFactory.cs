using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class LetterManagerFactory
    {
        static LetterManagerFactory factory = new LetterManagerFactory();
        public static LetterManagerFactory getFactory()
        {
            return factory;
        }
        public LetterManager createManager(String s)
        {
            /*LetterManager m = new LetterManager();
            int i = s.Length - 1;
            m.createLetter(ProxyLetterSpriteFactory.getFactory().createLetter(s[0]));
            while (i >= 1)
            {
                char t = s[i];
                m.createLetter(ProxyLetterSpriteFactory.getFactory().createLetter(t));
                i--;
            }
            return m;*/
            LetterManager m = new LetterManager();
            int i = s.Length - 1;
            
            while (i >= 0)
            {
                char t = s[i];
                m.createLetter(ProxyLetterSpriteFactory.getFactory().createLetter(s[i]));
                i--;
            }
            return m;
        }
    }
}
