using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CommandAlienTranslation : Command
    {
        MovementController movement;
        public CommandAlienTranslation(MovementController movement,long time, long timeOffset):base(time,timeOffset)
        {
            this.movement = movement;
        }
        public override void execute()
        {
            movement.translate();
        }
    }
}
