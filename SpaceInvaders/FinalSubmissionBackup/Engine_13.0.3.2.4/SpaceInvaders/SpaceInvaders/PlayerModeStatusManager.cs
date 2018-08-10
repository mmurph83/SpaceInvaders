using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerModeStatusManager : Manager
    {
        public void add(ObjectController controller)
        {
            AddToActive(new ObjectControllerStatusData(controller));
        }
        public void checkStatus()
        {
            DLink temp = pActive;
            while (temp != null)
            {
                ((ObjectControllerStatusData)temp).checkStatus();
                temp = temp.pNext;
            }
        }
        public void setStatus()
        {
            DLink temp = pActive;
            while (temp != null)
            {
                ((ObjectControllerStatusData)temp).setStatus();
                temp = temp.pNext;
            }
        }
    }
}
