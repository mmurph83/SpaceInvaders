using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class UFOCollisionController : CollisionController
    {
        UFOSpawnController controller;
        public UFOCollisionController(UFOSpawnController controller)
        {
            this.controller = controller;
        }
        public override void visit(ProjectileCollisionController c) {
            c.get().checkUFOCollision(controller.getUfo());
        }
    }
}
