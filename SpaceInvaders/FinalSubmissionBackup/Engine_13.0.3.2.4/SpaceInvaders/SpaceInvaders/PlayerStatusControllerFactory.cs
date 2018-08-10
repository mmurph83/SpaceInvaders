using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerStatusControllerFactory
    {
        static PlayerStatusControllerFactory factory = new PlayerStatusControllerFactory();
        PlayerStatusController controller;
        public PlayerStatusControllerFactory()
        {
            controller = new PlayerStatusController();
            controller.createNewPlayers(2);
        }
        public static PlayerStatusControllerFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public PlayerStatusController getController
        {
            get
            {
                return controller;
            }
        }
    }
}
