using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageList
    {
        static ImageList imageList = new ImageList();
        public static ImageList list
        {
            get
            {
                return imageList;
            }
        }
        public Image getImage(SpriteType name)
        {
            switch(name){
                case SpriteType.Bug:
                    return ImageFactoryBug.Instance.getImage(0);
                case SpriteType.Crab:
                    return ImageFactoryCrab.Instance.getImage(0);
                case SpriteType.Squid:
                    return ImageFactorySquid.Instance.getImage(0);
                case SpriteType.Player:
                    return ImageFactoryPlayer.InstancePlayer.getImage(0);
                case SpriteType.PlayerProjectile:
                    return ImageFactoryShield.Instance.getImage(0);
                case SpriteType.EnemyProjectile:
                    return ImageFactoryShield.Instance.getImage(0);
                case SpriteType.Shield:
                    return ImageFactoryShield.Instance.getImage(0);
                case SpriteType.UFO:
                    return ImageFactoryUFO.Instance.getImage(0);
                case SpriteType.Explosion:
                    return ImageFactoryExplosion.InstancePlayer.getImage(0);
                default:
                    return ImageFactoryBug.Instance.getImage(0);
            }
        }
    }
}
