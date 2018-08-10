using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GridSubjectCollisionController : CollisionController
    {
        CollisionSubject colSubj;
        public GridSubjectCollisionController(CollisionSubject colSubj)
        {
            this.colSubj = colSubj;
        }
        public CollisionSubject get()
        {
            return colSubj;
        }
        public override void checkCollision()
        {
            ColLink temp = head;
            while (temp != null)
            {
                ((CollisionControllerData)temp).getCol().visit(this);

                temp = temp.next;
            }
        }
        public override void visit(AlienCollisionController c)
        {
            colSubj.visit(c.get());
        }
        public override void visit(WallCollisionController c) {
            colSubj.visit(c.get());
        }
    }
}
