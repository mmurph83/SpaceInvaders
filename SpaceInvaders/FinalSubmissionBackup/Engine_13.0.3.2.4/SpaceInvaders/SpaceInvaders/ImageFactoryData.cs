using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryData : DLink
    {
        int imageNum;
        static Image image;
        public ImageFactoryData(int imageNum, Image im)
        {
            this.imageNum = imageNum;
            image = im;
        }
        public Image getImage()
        {
            return image;
        }
        public int getNum()
        {
            return imageNum;
        }
    }
}
