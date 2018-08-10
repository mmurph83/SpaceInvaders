using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class UFOSpawnControllerFactory
    {
        public UFOSpawnController controller;
        static UFOSpawnControllerFactory factory = new UFOSpawnControllerFactory();
        public UFOSpawnControllerFactory()
        {
            controller = new UFOSpawnController();
        }
        public static UFOSpawnControllerFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public UFOSpawnController getController
        {
            get {
              return controller;
            }
        }
    }
}
