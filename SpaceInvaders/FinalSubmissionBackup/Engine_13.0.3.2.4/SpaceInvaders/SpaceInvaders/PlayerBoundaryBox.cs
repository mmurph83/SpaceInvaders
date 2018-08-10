using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerBoundaryBox : Visitor
    {
        protected Player player;
        protected CollisionSprite boundaryBox;
        bool isHit = false;
        public PlayerBoundaryBox(Player player,CollisionSprite boundaryBox)
        {
            this.player = player;
            this.boundaryBox = boundaryBox;
        }
        public virtual void checkPlayerState(){
            if (player.getMovementDirection() == Movement.Stationary)
            {
                player.setMovementState(MovementStateFactory.still);
            }
        }
        public virtual void setPos(float x, float y)
        {
            boundaryBox.setPosition(x, y);
        }
        public virtual void translate(float x, float y)
        {
            boundaryBox.setPosition(x+getPosX(), y + getPosY());
        }
        public float getPosX()
        {
            return boundaryBox.getPosX();
        }
        public float getPosY()
        {
            return boundaryBox.getPosY();
        }
        public void checkCollision(CollisionSprite sprite)
        {
            if (sprite.checkCollision(sprite, boundaryBox))
            {
                checkPlayerState();
            }
        }
        public bool checkHit()
        {
            return isHit;
        }
        public override void visit(GridWallCollisionList grid)
        {
            if (isHit = grid.checkCollision(boundaryBox))
            {
                
                checkPlayerState();
            }
          
        }
        public void setScale(float x, float y)
        {
            boundaryBox.setScale(x, y);
        }
    }
}
