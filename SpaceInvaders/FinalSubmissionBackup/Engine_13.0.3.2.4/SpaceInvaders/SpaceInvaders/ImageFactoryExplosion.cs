using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryExplosion
    {
        private static Image image_001 = new Image(new Azul.Rect(384f, 640f, 128f, -128f));
       
        private static ImageFactoryExplosion imageFactory = new ImageFactoryExplosion();
        public static ImageFactoryExplosion InstancePlayer
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
