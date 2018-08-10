using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameControllerFactory
    {
        static GameControllerFactory factory = new GameControllerFactory();
        GameController controller;
        public GameControllerFactory()
        {
            controller = new GameController();
        }
        public static GameControllerFactory getFactory
        {
            get { return factory; }
        }
        public GameController c
        {
            get
            {
                return controller;
            }
        }
    }
}
