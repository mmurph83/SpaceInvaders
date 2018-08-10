using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ShieldCollisionController : CollisionController
    {
        ShieldList list;
        public ShieldCollisionController(ShieldList list)
        {
            this.list = list;
        }
        public ShieldList get()
        {
            return list;
        }
        public override CollisionController getCol()
        {
            return this;
        }
        public override void checkCollision()
        {
            ColLink temp = head;
            while (temp != null)
            {
                ((CollisionControllerData)temp).getCol().visit(this);
               
                temp = temp.next;
            }
        }
    }
}
