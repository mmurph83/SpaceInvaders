using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayGameResetCommand : Command
    {
        public PlayGameResetCommand():base(0,2000)
        {

        }
        public override void execute()
        {
            GameControllerFactory.getFactory.c.reset();
        }
    }
}
