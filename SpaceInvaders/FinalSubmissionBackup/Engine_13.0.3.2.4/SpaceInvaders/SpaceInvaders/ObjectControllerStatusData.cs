using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ObjectControllerStatusData : DLink
    {
        ObjectController objectController;
        Status currentStatus = Status.Active;
        public ObjectControllerStatusData(ObjectController objectController)
        {
            this.objectController = objectController;
        }
        public void checkStatus(){
            currentStatus = objectController.getStatus();
        }
        public void setStatus()
        {
            objectController.setStatus(currentStatus);
        }
    }
}
