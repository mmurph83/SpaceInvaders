using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerModeStatusManagerData : DLink
    {
        PlayerModeStatusManager manager;
        int playerNum = 0;
        public PlayerModeStatusManagerData(PlayerModeStatusManager manager, int num)
        {
            this.manager = manager;
            this.playerNum = num;
        }
        public int getPlayerNum()
        {
            return playerNum;
        }
        public PlayerModeStatusManager getManager()
        {
            return manager;
        }
    }
}
