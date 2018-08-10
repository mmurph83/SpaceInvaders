using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionControllerData : ColLink
    {
        CollisionController col;
        public CollisionControllerData(CollisionController c)
        {
            this.col = c;
        }
        public CollisionController getCol()
        {
            return col;
        }
        
    }
}
