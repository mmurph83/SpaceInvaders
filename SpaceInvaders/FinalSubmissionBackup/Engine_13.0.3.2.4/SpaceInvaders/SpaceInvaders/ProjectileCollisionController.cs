using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProjectileCollisionController : CollisionController
    {
        ProjectileController con;
        public ProjectileCollisionController(ProjectileController c)
        {
            this.con = c;
        }
        public ProjectileController get()
        {
            return con;
        }
        public override void visit(ShieldCollisionController c) {
            this.con.checkShieldCollision(c.get());
        }
        public override void visit(PlayerCollisionController c) {
            this.con.checkPlayerCollision(c.get().getPlayer());
        }
        public override void visit(ProjectileCollisionController c) {
            con.checkManagerCollision();
        }
        public override void visit(WallCollisionController c) {
            this.con.checkWallCollision(c.get());
        }
        public override void visit(AlienCollisionController c)
        {
            c.get().checkCollision(this.con.getPlayerManager());
        }
        public override CollisionController getCol()
        {
            return this;
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
