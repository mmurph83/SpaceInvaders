using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Projectile : ObjectController
    {
        
        MovementState movement;
        public Projectile(GameObject gameobject, MovementState movement): base(gameobject)
        {
            this.movement = movement;
        }
        public override void setPos(float x, float y)
        {
            this.gameObject.setPos(x, y);
        }
        public override void translate(float xOffset, float yOffset)
        {
            this.setPos(gameObject.getPosX() + (xOffset * movement.moveX()), gameObject.getPosY() + (yOffset * movement.moveY()));
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
