using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayScoreControllerFactory
    {
        PlayScoreController controller;
        static PlayScoreControllerFactory factory = new PlayScoreControllerFactory();
        PlayScoreControllerFactory()
        {
            controller = new PlayScoreController();

        }
        public static PlayScoreControllerFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public PlayScoreController playController
        {
            get
            {
                return controller;
            }
        }
    }
}
