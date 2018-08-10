using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class MovementStateFactory
    {
        static MovementDownState moveDown = new MovementDownState();
        static MovementLeftState moveLeft = new MovementLeftState();
        static MovementRightState moveRight = new MovementRightState();
        static MovementStateStationary moveStill = new MovementStateStationary();
        static MovementUpState moveUp = new MovementUpState();
        public static MovementRightState right{
            get
            {
                return moveRight;
            }
        }
        public static MovementDownState down{
            get
            {
                return moveDown;
            }
        }
        public static MovementLeftState left{
            get
            {
                return moveLeft;
            }
        }
        public static MovementStateStationary still
        {
            get
            {
                return moveStill;
            }
        }
        public static MovementUpState up
        {
            get
            {
                return moveUp;
            }
        }
    }
}
