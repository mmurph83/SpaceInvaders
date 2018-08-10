using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public static class AnimationFactory
    {
        public static AnimationManager makeAnimation(SpriteType name)
        {
            return new AnimationManager(ManagerConstructor.getImageManager(name), RealSpriteFactory.getSprite(name), name);
        }
    }
}
