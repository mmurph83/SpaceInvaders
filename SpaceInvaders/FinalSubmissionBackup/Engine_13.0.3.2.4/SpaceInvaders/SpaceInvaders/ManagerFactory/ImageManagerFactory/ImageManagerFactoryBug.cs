using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageManagerFactoryBug
    {
        static ImageManager ImageManager;
        private static ImageManagerFactoryBug imageManagerFactory = new ImageManagerFactoryBug();
        ImageManagerFactoryBug()
        {
            ImageManager = new ImageManager(0, SpriteType.Bug);
            ImageManager.createActive(ImageFactoryBug.Instance.getImage(0), 0);
            ImageManager.createActive(ImageFactoryBug.Instance.getImage(1), 1);
            
        }
        public static ImageManagerFactoryBug ImageManagerFactory
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
