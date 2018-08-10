using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class MovementController
    {
        GameObjectTree alienTree;
        MovementState direction = MovementStateFactory.left;
        MovementState directionDown = MovementStateFactory.down;
        private bool isHit = false;
        Status status = Status.Active;
        Command translationCommand;
        Command animationCommand;
        private float distance = 5f;
        private float distanceDown = 20f;
        private long timeOffset = 1000;
        public MovementController()
        {
           
        }
        public void setMovementDirection(MovementState state)
        {
            this.direction = state;
        }
        public void changeDirection(MovementState move)
        {
            this.direction = move;
        }
        public void canMoveDown(){
            isHit = true;
        }
        public Movement getMovement()
        {
            return direction.getMovementDir();
        }
        public MovementController(GameObjectTree gameTree)
        {
            this.alienTree = gameTree;
            translationCommand = new CommandAlienTranslation(this, 10, timeOffset);
            animationCommand = new CommandAnimationAlien(this, 10, timeOffset);
           
           //Receiver.instance.addCommand(translationCommand);
           
            
        }
        public void addCommandToReceiver()
        {
            Receiver.instance.addCommand(translationCommand);
        }
        public void setPos(float x, float y, float xOffset, float yOffset)
        {
            alienTree.setPos(x, y, xOffset, yOffset);
        }
        public void translate()
        {
            if (status == Status.Active)
            {
                if (!isHit)
                {
                    alienTree.translate(direction.moveX() * distance, direction.moveY() * distanceDown);
                }
                else
                {
                    alienTree.translate(directionDown.moveX() * distance, directionDown.moveY() * distanceDown);
                    isHit = false;
                }



                
                //alienTree.performLowest(0);
                //alienTree.performLowest(6);
                animationCommand.execute();
            }
            float a = (float)(((float)alienTree.totalActive()) / ((float)alienTree.getTotalElements()));
            long t = (long)(a*(float)timeOffset);
            Console.WriteLine(t);
            translationCommand.setTimeOffset(t);
            Receiver.instance.addCommand(translationCommand);
        }
        public void setActive(Status s)
        {
            this.status = s;
        }
        public void fireProjectile(CommandProjectileSpawn s)
        {
            if (status == Status.Active)
            {
                alienTree.performLowest(s.getColumnNum());
                
            }
            s.addToReceiver();
        }
        public void checkCollision(ProjectileManager projectileManager)
        {
            projectileManager.sendProjectiles(alienTree);
        }
        public void checkShieldCollision(ShieldList list)
        {
            list.checkAlienCollision(this.alienTree);
        }
        public void setAllActive(Status s)
        {
            alienTree.setAllActive(s);
        }
        public Status getStatus()
        {
            return alienTree.getStatus();
        }
        public GameObjectTree getTree()
        {
            return alienTree;
        }
    }
}
