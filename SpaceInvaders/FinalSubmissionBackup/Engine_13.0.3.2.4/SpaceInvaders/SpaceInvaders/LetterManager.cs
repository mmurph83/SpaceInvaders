using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class LetterManager : Manager
    {
        public void createLetter(ProxyLetterSprite s)
        {
            DLink temp = new LetterDataNode(s,active);
            AddToActive(temp);
        }
        public void setPos(float x, float y)
        {
            DLink temp = pActive;
            if (temp != null)
            {
                float offsetX = ((LetterDataNode)temp).getSprite().getWidth();
                float offsetY = ((LetterDataNode)temp).getSprite().getHeight();
                float i = 0;
                while (temp != null)
                {
                    ((LetterDataNode)temp).setPos(x +(i*offsetX), y);
                    i++;
                    temp = temp.pNext;
                }
            }
        }
        public void setStatus(Status status)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                ((LetterDataNode)temp).getSprite().setStatus(status);
                temp = temp.pNext;
            }
        }
        public void setImage(string s)
        {
            DLink temp = pActive;
            for (int i = 0; i < active && i < s.Length - 1; i++)
            {
                ((LetterDataNode)temp).setImage(ImageFactoryLetter.getFactory().getImage(s[i]));
            }
        }
        public void setImageReverse(string s)
        {
            DLink temp = pActive;
            int j = (s.Length) - active;
            for (int i = 0; i < active && j < s.Length - 1; i++, j++)
            {
                if (j >= 0)
                {
                    ((LetterDataNode)temp).setImage(ImageFactoryLetter.getFactory().getImage(s[j]));
                }
                else
                {
                    ((LetterDataNode)temp).setImage(ImageFactoryLetter.getFactory().getImage('0'));
                }
                temp = temp.pNext;
            }
        }
    }
}
