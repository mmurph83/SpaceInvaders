using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AlienCollisionController : CollisionController
    {
        MovementController con;
        public AlienCollisionController(MovementController con)
        {
            this.con = con;
        }
        public override void visit(ShieldCollisionController c) {
            con.checkShieldCollision(c.get());
        }
        public override void visit(ProjectileCollisionController c) {
            con.checkCollision(c.get().getPlayerManager());
        }
        public MovementController get()
        {
            return con;
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
        
    }
}
