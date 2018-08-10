using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageManagerFactoryPlayer
    {
    static ImageManager crabImageManager;
        private static ImageManagerFactoryPlayer imageManagerFactory = new ImageManagerFactoryPlayer();
        ImageManagerFactoryPlayer()
        {
            crabImageManager = new ImageManager(0, SpriteType.Player);
            crabImageManager.createActive(ImageFactoryPlayer.InstancePlayer.getImage(0), 0);
            crabImageManager.createActive(ImageFactoryPlayer.InstancePlayer.getImage(1), 1);
            
        }
        public static ImageManagerFactoryPlayer PlayerImageManagerFactory
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
                return crabImageManager;
            }
            set
            {
                
            }
        }
    }
}
