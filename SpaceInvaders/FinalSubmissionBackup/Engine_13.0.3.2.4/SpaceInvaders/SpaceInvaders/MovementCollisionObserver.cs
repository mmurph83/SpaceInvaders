using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class MovementCollisionObserver : CollisionObserver
    {
        MovementController movementController;
        bool canRespond = true;
        public MovementCollisionObserver(MovementController movementController)
        {
            this.movementController = movementController;
        }
        public override void notifyCollisionType(SpriteType name)
        {
            if (name == SpriteType.Wall)
            {
                if (canRespond)
                {
                    if (movementController.getMovement() == Movement.Left)
                    {
                        movementController.changeDirection(MovementStateFactory.right);
                    }
                    else
                    {
                        movementController.changeDirection(MovementStateFactory.left);
                    }
                    movementController.canMoveDown();
                    canRespond = false;
                }
            }
            else {
                canRespond = true;
            }
        }
    }
}
