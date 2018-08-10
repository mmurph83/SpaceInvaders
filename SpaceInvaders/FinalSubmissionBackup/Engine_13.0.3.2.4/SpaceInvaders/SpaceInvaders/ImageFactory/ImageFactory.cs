using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    /*public class ImageFactory
    {
        private static ImageFactory imageFactory;
        protected static DLink imageData;
        protected Image createImage(float x, float y, float width, float height)
        {
            return new Image(new Azul.Rect(x,y,width,height));
        }
        protected virtual void createImages(){

        }
        public static ImageFactory Instance
        {
            get
            {
                if (imageFactory == null)
                {
                    imageFactory = new ImageFactory();
                }
                return imageFactory;
            }
        }
        protected void addImage(Image image)
        {
            if (imageData == null)
            {
                imageData = new ImageFactoryData(0, image);

            }
            else
            {
                int i = 1;
                DLink temp = imageData;
                while (temp.pNext != null)
                {
                    i++;
                    temp = temp.pNext;
                }
                temp.pNext = new ImageFactoryData(i, image);
            }
        }
        public Image getImage(int num)
        {
            if (imageData == null)
            {
                createImages();
            }
            DLink temp = imageData;
            while (temp.pNext != null && ((ImageFactoryData)temp).getNum() != num)
            {
                temp = temp.pNext;
            }
            return ((ImageFactoryData)temp).getImage();
        }
    }*/
}
