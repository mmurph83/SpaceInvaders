using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    
    public class UFOSpawnController 
    {
        Alien ufo = GameObjectTreeFactory.getFactory.getUfo();
        UFOSpawnCommand command;
        MovementState state = MovementStateFactory.still;
        
        float speed = 1f;
        float xL = 0f;
        float xR = 896f;
        float Y = 700f;
        public UFOSpawnController()
        {
            command = new UFOSpawnCommand(this,0,1000);
        }
        void translate()
        {
            if (ufo.getStatus() == Status.Active)
            {
                ufo.setPos(ufo.getPosX() + (speed * state.moveX()), ufo.getPosY() + (speed * state.moveY()));
            }
        }

        public void Update()
        {
            if (ufo.getPosX() > xL && ufo.getPosX() < xR)
            {
                translate();
            }
            else
            {
                setStatus(Status.Inactive);
            }
            
        }
        public Alien getUfo()
        {
            return ufo;
        }
        public void checkProjectileCollision(Projectile projectile)
        {
            if (ufo.getCollisionComponent().checkCollision(projectile.getCollisionComponent(), ufo.getCollisionComponent()))
            {
                ufo.setStatus(Status.Inactive);
                projectile.setStatus(Status.Inactive);
            }
        }
        public void addToReceiver()
        {
            Receiver.instance.addCommand(command);
        }
        public void setStatus(Status status)
        {
            ufo.setStatus(status);
        }
        public void setState(MovementState state)
        {
            this.state = state;
        }
        public void setPos(float x, float y)
        {
            ufo.setPos(x, y);
        }
    }
}
