using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerCollisionController : CollisionController
    {
        PlayerInputController controller;
        public PlayerCollisionController(PlayerInputController controller)
        {
            this.controller = controller;
        }

        public PlayerInputController get()
        {
            return controller;
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
        public override void visit(WallCollisionController c) {
            controller.checkWallCollision(c.get());
        }
    }
}
