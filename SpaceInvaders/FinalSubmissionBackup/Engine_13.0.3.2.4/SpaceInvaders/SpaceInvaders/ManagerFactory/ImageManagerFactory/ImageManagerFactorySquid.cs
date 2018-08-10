using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageManagerFactorySquid
    {
        static ImageManager ImageManager;
        private static ImageManagerFactorySquid imageManagerFactory = new ImageManagerFactorySquid();
        ImageManagerFactorySquid()
        {
            ImageManager = new ImageManager(0, SpriteType.Squid);
            ImageManager.createActive(ImageFactorySquid.Instance.getImage(0), 0);
            ImageManager.createActive(ImageFactorySquid.Instance.getImage(1), 1);
            
        }
        public static ImageManagerFactorySquid ImageManagerFactory
        {
            get
            {
                
                return imageManagerFactory;
            }
           
        }
        public ImageManager getImageManager
        {
            get
            {
                return ImageManager;
            }
            set
            {
                
            }
        }
    }
    
}
