using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public static class ProxySpriteFactory
    {
        public static Sprite makeProxySprite(SpriteType name)
        {
            return new ProxySprite(name, RealSpriteFactory.getSprite(name));
        }
    }
}
