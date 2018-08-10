using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class GameObjectNode : GameObjectTree
    {
        ObjectController gameObject;
        int rowNum = 0;
        public GameObjectNode(int rowNum): base()
        {
            this.rowNum = rowNum;
        }
        public override float getPosX()
        {
            return gameObject.getPosX();
        }
        public override float getPosY()
        {
            return gameObject.getPosY();
        }
        public void setObj(ObjectController gameObject)
        {
            this.gameObject = gameObject;
        }
        public override void setPos(float x, float y, float xOffset, float yOffset)
        {
            this.gameObject.setPos(x,y);
        }
        public override void translate(float xOffset, float yOffset)
        {
            gameObject.setPos(gameObject.getPosX() + xOffset, gameObject.getPosY() + yOffset);
        }
        public override int getNum()
        {
            return rowNum;
        }
        public override float getLowestHeight()
        {
            return getPosY();
        }
        public override CollisionSprite getCollisionComponent()
        {
            return gameObject.getCollisionComponent();
        }
        public override void setCollisionComponent()
        {
            collisionComponent = gameObject.getCollisionComponent();
        }
        public override ObjectController acceptGameObjectVisit(CollisionSprite visitor)
        {
            GameObjectTree columnTemp = activeColumns;


            if (this.acceptGridVisit(visitor))
            {
                return gameObject;
            }
            return null;
        }
        public override void performLowest(int column)
        {
            if (this.getStatus() == Status.Active)
            {
                gameObject.perform();
            }
        }
        public override void checkGameObjectTreeCollision(GameObjectTree tree)
        {
            if (tree.getCollisionComponent().checkCollision(tree.getCollisionComponent(), gameObject.getCollisionComponent()))
            {
                gameObject.notifyHit();
            }
        }
        public override void setAllActive(Status st)
        {
            gameObject.setStatus(st);
        }
        public override bool checkProjectileCollision(Projectile projectile)
        {
            if (projectile.getCollisionComponent().checkCollision(gameObject.getCollisionComponent(), projectile.getCollisionComponent()))
            {
                projectile.notifyHit();
                gameObject.notifyHit();
                return true;
            }
            return false;
        }
        public override Status getStatus()
        {
            return gameObject.getStatus();
        }
        public override int totalActive()
        {
            return 1;
        }
    }
}
