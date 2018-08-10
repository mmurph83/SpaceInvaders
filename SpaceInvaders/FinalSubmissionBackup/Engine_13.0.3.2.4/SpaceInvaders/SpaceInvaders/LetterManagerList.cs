using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class LetterManagerList : Manager
    {
        public void addManager(LetterManager manager)
        {
            AddToActive(new LetterManagerDataNode(manager));
        }
        public void setStatus(Status status)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                ((LetterManagerDataNode)temp).setStatus(status);
                temp = temp.pNext;
            }
        }
    }
}
