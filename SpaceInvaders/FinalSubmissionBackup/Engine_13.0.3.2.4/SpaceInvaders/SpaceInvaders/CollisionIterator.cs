using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionIterator
    {
        ColLink head;
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
        public void checkCollision()
        {
            ColLink temp = head;
            while (temp != null)
            {
                ((CollisionControllerData)temp).getCol().checkCollision();
                temp = temp.next;
            }
        }
    }
}
