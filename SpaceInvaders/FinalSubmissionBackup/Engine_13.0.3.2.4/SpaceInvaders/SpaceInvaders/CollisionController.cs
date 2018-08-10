using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionController : Visitor
    {
        protected ColLink head;
        public void addCollision(CollisionController col)
        {
            if (head == null)
            {
                head = new CollisionControllerData(col);
            }
            else
            {
                ColLink temp = new CollisionControllerData(col);
                temp.next = head;
                head = temp;
            }
        }
        public virtual void checkCollision()
        {
            ColLink temp = head;
            while (temp != null)
            {
               ((CollisionControllerData)temp).getCol().visit(this);
               
                temp = temp.next;
            }
        }
        public virtual CollisionController getCol()
        {
            return this;
        }
    }
}
