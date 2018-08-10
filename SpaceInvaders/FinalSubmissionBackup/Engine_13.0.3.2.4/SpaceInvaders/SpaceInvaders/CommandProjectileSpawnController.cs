using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CommandProjectileSpawnController
    {
        DLink projectileSpawnHead;
        public void addCommand(CommandProjectileSpawn spawn)
        {
            DLink temp = new CommandProjectileSpawnData(spawn);
            if (projectileSpawnHead == null)
            {
                this.projectileSpawnHead = temp;
            }
            else
            {
                temp.pNext = projectileSpawnHead;
                projectileSpawnHead = temp;
            }
        }
        public void addToReceiver()
        {
            DLink temp = projectileSpawnHead;
            while (temp != null)
            {
                ((CommandProjectileSpawnData)temp).getSpawn().addToReceiver();
                temp = temp.pNext;
            }
        }
    }
}
