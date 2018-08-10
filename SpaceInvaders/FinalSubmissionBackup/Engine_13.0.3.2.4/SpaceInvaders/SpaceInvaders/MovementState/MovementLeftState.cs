using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class MovementLeftState : MovementState
    {
        public MovementLeftState()
        {
            movementDir = Movement.Left;
        }
        public override float moveX()
        {
            return -1;
        }
        public override float moveY()
        {
            return 0;
        }
    }
}
