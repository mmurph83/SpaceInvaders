using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryUFO
    {
        private static Image image_001 = new Image(new Azul.Rect(512f, 768f, 128f, -128f));

        private static ImageFactoryUFO imageFactory = new ImageFactoryUFO();
        public static ImageFactoryUFO Instance
        {
            get
            {
                return imageFactory;
            }
        }
        public Image getImage(int num)
        {
            return image_001;
        }
    }
}
