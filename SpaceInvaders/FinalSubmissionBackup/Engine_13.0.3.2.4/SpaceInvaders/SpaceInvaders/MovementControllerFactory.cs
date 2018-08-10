using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class MovementControllerFactory
    {
        MovementController controller;
        static MovementControllerFactory factory = new MovementControllerFactory();
        public MovementControllerFactory()
        {
            this.controller = new MovementController(GameObjectTreeFactory.getFactory.alien);
        }
        public static MovementControllerFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public MovementController getController()
        {
            return controller;
        }
    }
}
