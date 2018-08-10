using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageManagerFactoryCrab
    {
        static ImageManager crabImageManager;
        private static ImageManagerFactoryCrab imageManagerFactory = new ImageManagerFactoryCrab();
        ImageManagerFactoryCrab()
        {
            crabImageManager = new ImageManager(0, SpriteType.Crab);
            crabImageManager.createActive(ImageFactoryCrab.Instance.getImage(0), 0);
            crabImageManager.createActive(ImageFactoryCrab.Instance.getImage(1), 1);
            
        }
        public static ImageManagerFactoryCrab CrabImageManagerFactory
        {
            get
            {
                
                return imageManagerFactory;
            }
           
        }
        public ImageManager getImageManagerCrab
        {
            get
            {
                return crabImageManager;
            }
            set
            {
                
            }
        }
    }
}
