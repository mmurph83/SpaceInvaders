using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class MovementState
    {
        protected Movement movementDir = Movement.Stationary;
        public virtual float moveX()
        {
            return 0;
        }
        public virtual float moveY()
        {
            return 0;
        }
        public Movement getMovementDir()
        {
            return movementDir;
        }
    }
    public enum Movement {Left,Right,Up,Down, Stationary }
}
