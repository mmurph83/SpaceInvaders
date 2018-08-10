using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class WallCollisionController : CollisionController
    {
        GridWallCollisionList list;
        public WallCollisionController(GridWallCollisionList list)
        {
            this.list = list;
        }
        public GridWallCollisionList get()
        {
            return list;
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
