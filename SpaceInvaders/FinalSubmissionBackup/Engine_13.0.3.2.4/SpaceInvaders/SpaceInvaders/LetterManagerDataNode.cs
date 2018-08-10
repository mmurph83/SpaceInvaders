using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class LetterManagerDataNode : DLink
    {
        LetterManager manager;
        public LetterManagerDataNode(LetterManager manager)
        {
            this.manager = manager;
        }
        public void setStatus(Status status){
            manager.setStatus(status);
       }
    }
}
