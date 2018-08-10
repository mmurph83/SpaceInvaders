using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryShield
    {
        private static Image image_001 = new Image(new Azul.Rect(64f, 960f, 1f, -1f));
        
        private static ImageFactoryShield imageFactory = new ImageFactoryShield();
        public static ImageFactoryShield Instance
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
