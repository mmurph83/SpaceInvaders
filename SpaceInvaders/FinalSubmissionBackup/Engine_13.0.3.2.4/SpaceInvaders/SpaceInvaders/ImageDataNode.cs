using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageDataNode : DLink
    {
        private SpriteType name;
        private Image image;
        private int num;
        public ImageDataNode(Image image, SpriteType name, int num)
        {
            this.name = name;
            this.image = image;
        }
        public SpriteType getName()
        {
            return name;
        }
        public int getNum()
        {
            return num;
        }
        public void setSpriteType(SpriteType name)
        {
            this.name = name;
        }
        public void setImage(Image image)
        {
            this.image = image;
        }
        public Image getImage()
        {
            return image;
        }
    }
}
