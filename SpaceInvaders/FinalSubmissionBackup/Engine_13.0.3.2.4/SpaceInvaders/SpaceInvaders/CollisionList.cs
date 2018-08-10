using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionList : Visitable
    {
        protected CLink headCollisionTests;
        public CollisionList()
        {

        }
        public virtual bool checkCollision()
        {
            return false;
        }
    }
}
