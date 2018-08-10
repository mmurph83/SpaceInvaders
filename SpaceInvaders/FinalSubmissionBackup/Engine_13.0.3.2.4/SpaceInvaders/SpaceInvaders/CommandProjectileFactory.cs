using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CommandProjectileFactory
    {
        static CommandProjectileFactory factory = new CommandProjectileFactory();
        public CommandProjectileSpawnController command;
        public CommandProjectileFactory()
        {
            command = new CommandProjectileSpawnController();
            CommandProjectileSpawn s = new CommandProjectileSpawn(MovementControllerFactory.getFactory.getController());
            for (int i = 0; i < 10; i = i + 2)
            {
                s.addColumn(i);
            }
            
            s.addOffset(2500);
            command.addCommand(s);
            s = new CommandProjectileSpawn(MovementControllerFactory.getFactory.getController());
            for (int i = 9; i > 0; i = i - 2)
            {
                s.addColumn(i);
            }

            s.addOffset(2000);
            command.addCommand(s);
        }
        public static CommandProjectileFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public CommandProjectileSpawnController controller
        {
            get
            {
                return command;
            }
        }
    }
}
