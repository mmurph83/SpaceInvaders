using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ObserverData : OLink
    {
        CollisionObserver collisionObserver;
        public ObserverData(CollisionObserver collisionObserver)
        {
            this.collisionObserver = collisionObserver;
        }
        public CollisionObserver getObserver()
        {
            return collisionObserver;
        }
    }
}
