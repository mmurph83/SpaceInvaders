using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AnimationManager
    {
        ImageManager iManager;
        Sprite sprite;
        SpriteType name;
        int totalImages = 0;
        int currentImage = 0;
        public AnimationManager(ImageManager iManager, Sprite sprite, SpriteType name)
        {
            this.iManager = iManager;
            this.sprite = sprite;
            this.name = name;
            totalImages = iManager.getTotalImages();
        }
        public void setAnimationToNextImage()
        {
            currentImage++;
            if (currentImage >= totalImages)
            {
                currentImage = 0;
            }
            sprite.setImage(iManager.findImage(currentImage));
            sprite.Update();
        }
        public void resetImage()
        {
            currentImage = 0;
            sprite.setImage(iManager.findImage(currentImage));
            sprite.Update();
        }
        public SpriteType getName()
        {
            return name;
        }
    }
}
