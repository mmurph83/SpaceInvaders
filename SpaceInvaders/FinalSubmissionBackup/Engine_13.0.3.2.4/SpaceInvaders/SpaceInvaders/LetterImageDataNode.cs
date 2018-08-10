using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class LetterImageDataNode : ILink
    {
        Image image;
        char c;
        public LetterImageDataNode(Image image, char c)
        {
            this.image = image;
            this.c = c;
        }
        public Image getImage()
        {
            return this.image;
        }
        public char getChar()
        {
            return c;
        }
    }
}
