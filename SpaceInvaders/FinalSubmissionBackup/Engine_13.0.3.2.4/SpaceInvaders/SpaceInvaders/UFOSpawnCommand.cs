using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class UFOSpawnCommand : Command
    {
        UFOSpawnController controller;
        public UFOSpawnCommand(UFOSpawnController controller,long time, long timeOffset):base(time,timeOffset)
        {
            this.controller = controller;
        }
        public override void execute()
        {
            controller.setStatus(Status.Active);
            controller.setState(MovementStateFactory.left);
            controller.setPos(895, 900);
        }
    }
}
