using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryCrab
    {
        private static Image image_001 = new Image(new Azul.Rect(512f, 1024f, 128f, -128f));
        private static Image image_002 = new Image(new Azul.Rect(640f, 1024f, 128f, -128f));
        private static ImageFactoryCrab imageFactory  = new ImageFactoryCrab();
        public static ImageFactoryCrab Instance
        {
            get
            {
                return imageFactory;
            }
        }
        public Image getImage(int num)
        {
            switch(num){
                case 0:
                    return image_001;
                default:
                    return image_002;

            }
        }
        
    }
}
