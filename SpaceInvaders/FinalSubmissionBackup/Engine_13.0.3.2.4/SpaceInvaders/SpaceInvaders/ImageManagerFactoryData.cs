using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageManagerFactoryData : DLink
    {
        ImageManager imageManager;
        SpriteType name;
        public ImageManagerFactoryData(ImageManager imageManager, SpriteType name)
        {
            this.imageManager = imageManager;
            this.name = name;
        }
        public SpriteType getName()
        {
            return name;
        }
        public ImageManager getImageManager()
        {
            return imageManager;
        }
    }
}
