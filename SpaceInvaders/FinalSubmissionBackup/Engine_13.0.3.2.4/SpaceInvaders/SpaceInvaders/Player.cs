using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Player : ObjectController
    {
        MovementState direction = MovementStateFactory.still;
        PlayerBoundaryBox leftBox;
        PlayerBoundaryBox rightBox;
        float offset = 20f;
        //col observers
        public Player(GameObject gameObject):base(gameObject)
        {
            Scale t = SizeFactory.getFactory.boundaryScale;
            this.leftBox = new PlayerBoundaryBoxLeft(this, ProxySpriteCollisionFactory.proxy);
            leftBox.setScale(t.colWidth, t.colHeight);
            this.rightBox = new PlayerBoundaryBoxRight(this, ProxySpriteCollisionFactory.proxy);
            rightBox.setScale(t.colWidth, t.colHeight);
            gameObject.setScale(SizeFactory.getFactory.playerScale.spriteWidth, SizeFactory.getFactory.playerScale.spriteHeight);
            offset = SizeFactory.getFactory.playerScale.spriteWidth;
        }
        public Player(GameObject gameObject, PlayerBoundaryBoxLeft leftBox, PlayerBoundaryBoxRight rightBox)
            : base(gameObject)
        {
            this.leftBox = leftBox;
            this.rightBox = rightBox;
        }
        public void setMovementState(MovementState direction)
        {
            this.direction = direction;
        }
        public Movement getMovementDirection()
        {
            return direction.getMovementDir();
        }
        public bool canMoveLeft()
        {
            return !leftBox.checkHit();
        }
        public bool canMoveRight()
        {
            return !rightBox.checkHit();
        }
        public override void translate(float xOffset, float yOffset)
        {
            this.setPos(gameObject.getPosX() + (xOffset*direction.moveX()), gameObject.getPosY() + (yOffset*direction.moveY()));
            this.leftBox.setPos(gameObject.getPosX() - offset, gameObject.getPosY());
            this.rightBox.setPos(gameObject.getPosX() + offset, gameObject.getPosY());
        }
        public void setBoundaryScale(float x, float y)
        {
            leftBox.setScale(x, y);
            rightBox.setScale(x, y);
        }
        public override void setStatus(Status status)
        {
            gameObject.setStatus(status);
        }
        public override void visit(GridWallCollisionList grid)
        {
            leftBox.visit(grid);
            rightBox.visit(grid);
        }
        public override void notifyHit()
        {
            gameObject.setStatus(Status.Inactive);
        }
    }
}
