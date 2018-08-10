using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public static class ManagerConstructor
    {
        
        /*public static ManagerConstructor Manager_Constructor()
        {
            if (managerConstructor == null)
            {
                managerConstructor = new ManagerConstructor();
            }
            return managerConstructor;
        }*/
        public static ImageManager getImageManager(SpriteType name)
        {
            switch(name){
                case SpriteType.Crab:
                    return ImageManagerFactoryCrab.CrabImageManagerFactory.getImageManagerCrab;
                case SpriteType.Bug:
                    return ImageManagerFactoryBug.ImageManagerFactory.getImageManager;
                case SpriteType.Squid:
                    return ImageManagerFactorySquid.ImageManagerFactory.getImageManager;
                case SpriteType.Player:
                    return ImageManagerFactoryPlayer.PlayerImageManagerFactory.getImageManager;
                default:
                    return null;
            }
        }
        
    }
}
