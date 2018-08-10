using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryLetter
    {
        ILink number;
        ILink letter;
        ILink other;
        static ImageFactoryLetter letterFactory = new ImageFactoryLetter();
        public static ImageFactoryLetter getFactory()
        {
            return letterFactory;
        }
        public ImageFactoryLetter()
        {
            char let = 'A';
            
            letter = new LetterImageDataNode(new Image(new Azul.Rect(0, 320, 64, -64)), let);
            ILink temp = letter;
            let++;
            for (int i = 1; i < 13; i++, let++)
            {
                temp.next = new LetterImageDataNode(new Image(new Azul.Rect(64*i, 320, 64, -64)), let);
                Console.WriteLine(let);
                temp = temp.next;
            }
            for (int i = 0; i < 13; i++, let++)
            {
                temp.next = new LetterImageDataNode(new Image(new Azul.Rect(64 * i, 256, 64, -64)), let);
                Console.WriteLine(let);
                temp = temp.next;
            }
            number = new LetterImageDataNode(new Image(new Azul.Rect(0, 388, 64, -64)), '0');
            temp = number;
            let = '0';
            let++;
            for (int i = 1; i < 10; i++,let++)
            {
                temp.next = new LetterImageDataNode(new Image(new Azul.Rect(i*64, 388, 64, -64)), let);
                temp = temp.next;
            }
            other = new LetterImageDataNode(new Image(new Azul.Rect(64 * 4, 448, 64, -64)), '<');
            other.next = new LetterImageDataNode(new Image(new Azul.Rect(64 * 6, 448, 64, -64)), '>');
            other.next.next = new LetterImageDataNode(new Image(new Azul.Rect(64 * 4, 180, 64, -64)), '-');
            other.next.next.next = new LetterImageDataNode(new Image(new Azul.Rect(0,0,0,0)), ' ');
        }
        public Image getImage(char c)
        {
            if (c >= '0' == c <= '9')
            {
                return this.getLetterNumber(c);
            }
            else if (c >= 'A' == c <= 'Z')
            {
                return this.getLetter(c);
            }
            else
            {
                return this.getLetterSymbol(c);
            }
        }
        Image getLetter(char let)
        {
            ILink temp = letter;
            while (temp.next != null && ((LetterImageDataNode)temp).getChar() != let)
            {
                temp = temp.next;
            }
            return ((LetterImageDataNode)temp).getImage();
        }
        Image getLetterNumber(char num)
        {
            ILink temp = number;
            while (temp.next != null && ((LetterImageDataNode)temp).getChar() != num)
            {
                temp = temp.next;
            }
            return ((LetterImageDataNode)temp).getImage();
        }
        Image getLetterSymbol(char sym)
        {
            ILink temp = other;
            while (temp.next != null && ((LetterImageDataNode)temp).getChar() != sym)
            {
                temp = temp.next;
            }
            return ((LetterImageDataNode)temp).getImage();
        }
    }
}
