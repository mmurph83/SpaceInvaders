using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerInputControllerFactory
    {
        PlayerInputController inputController;
        static PlayerInputControllerFactory factory = new PlayerInputControllerFactory();
        public PlayerInputControllerFactory()
        {
            inputController = new PlayerInputController(PlayerFactory.instance.getPlayer());
        }
        public static PlayerInputControllerFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public PlayerInputController getController()
        {
            return inputController;
        }
    }
}
