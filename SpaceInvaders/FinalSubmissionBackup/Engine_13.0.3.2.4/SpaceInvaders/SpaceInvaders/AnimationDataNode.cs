using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AnimationDataNode : ALink
    {
        AnimationManager manager;
       
        public AnimationDataNode(AnimationManager manager)
        {
            this.manager = manager;
            
        }
        public AnimationManager getManager()
        {
            return manager;
        }
        public SpriteType getName()
        {
            return manager.getName();
        }
    }
}
