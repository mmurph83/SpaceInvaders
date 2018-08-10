using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryPlayer
    {

        private static Image image_001 = new Image(new Azul.Rect(0f, 640f, 128f, -128f));
       
        private static Image image_002 = new Image(new Azul.Rect(128f, 640f, 128f, -128f));
        private static ImageFactoryPlayer imageFactory = new ImageFactoryPlayer();
        public static ImageFactoryPlayer InstancePlayer
        {
            get
            {
                return imageFactory;
            }
        }
        public Image getImage(int num)
        {
            switch (num)
            {
                case 0:
                    return image_001;
                default:
                    return image_002;

            }
        }
    }
}
