using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CommandProjectileSpawnData : DLink
    {
        CommandProjectileSpawn spawn;
        public CommandProjectileSpawnData(CommandProjectileSpawn spawn)
        {
            this.spawn = spawn;
        }
        public CommandProjectileSpawn getSpawn()
        {
            return spawn;
        }
    }
}
