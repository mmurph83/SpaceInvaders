using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Shield : ObjectController
    {
        public Shield(GameObject gameObject)
            : base(gameObject)
        {

        }
        public override void notifyHit()
        {
            gameObject.setStatus(Status.Inactive);
        }
        public override void setStatus(Status status)
        {
            gameObject.setStatus(status);
        }
    }
}
