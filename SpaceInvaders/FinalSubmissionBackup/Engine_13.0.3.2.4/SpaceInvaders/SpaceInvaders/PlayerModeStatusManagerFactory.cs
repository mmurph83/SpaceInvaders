using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerModeStatusManagerFactory
    {
        static PlayerModeStatusManagerFactory factory = new PlayerModeStatusManagerFactory();
        DLink managerHead;
        public static PlayerModeStatusManagerFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        PlayerModeStatusManagerFactory()
        {
            managerHead = new PlayerModeStatusManagerData(new PlayerModeStatusManager(), 0);
            managerHead.pNext = new PlayerModeStatusManagerData(new PlayerModeStatusManager(), 2);
        }
        public void addObject(ObjectController controller)
        {
            DLink temp = managerHead;
            while (temp != null)
            {
                ((PlayerModeStatusManagerData)temp).getManager().add(controller);
                temp = temp.pNext;
            }
        }
        public PlayerModeStatusManager getPlayModeStatusManager(int num)
        {
            DLink temp = managerHead;
            while (temp.pNext != null && ((PlayerModeStatusManagerData)temp).getPlayerNum() != num)
            {
                temp = temp.pNext;
            }
            return ((PlayerModeStatusManagerData)temp).getManager();
        }
        
    }
}
