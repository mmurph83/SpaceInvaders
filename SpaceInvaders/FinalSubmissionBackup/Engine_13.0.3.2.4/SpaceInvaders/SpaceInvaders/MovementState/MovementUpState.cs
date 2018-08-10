using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class MovementUpState:MovementState
    {
        public override float moveX()
        {
            return 0;
        }
        public override float moveY()
        {
            return 1;
        }
    }
}
