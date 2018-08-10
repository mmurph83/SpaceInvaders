using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameObjectTree : Visitable
    {
        protected CollisionSprite collisionComponent;
        protected GameObjectTree activeColumns;
        public GameObjectTree nextNode;
        protected GameObjectTree reserveColumns;
        protected GameObjectTree parentPointer;
        protected int total = 0;

        protected Status currentStatus = Status.Active;
        public GameObjectTree()
        {
            this.collisionComponent = ProxySpriteCollisionFactory.proxy;
        }
        public virtual void AddToActive(int column, int row, ObjectController gameObject)
        {
            total++;
            if (activeColumns == null)
            {
                activeColumns = new GameObjectColumn(column);
                activeColumns.AddToActive(column, row, gameObject);
            }
            else
            {
                GameObjectTree columnTemp = activeColumns;
                while (columnTemp.nextNode != null && columnTemp.getNum() != column)
                {
                    columnTemp = columnTemp.nextNode;
                }
                if (columnTemp.getNum() != column)
                {
                    columnTemp.nextNode = new GameObjectColumn(column);
                    columnTemp = columnTemp.nextNode;
                    
                }
                columnTemp.AddToActive(column, row, gameObject);
            }
        }
        public int getTotalElements()
        {
            return total;
        }
        public virtual int totalActive()
        {
            if (this.currentStatus == Status.Active)
            {
                int i = 0;
                GameObjectTree columnTemp = activeColumns;
                while (columnTemp != null)
                {
                    if (columnTemp.getStatus() == Status.Active)
                    {
                        i = i + columnTemp.totalActive();
                    }
                    columnTemp = columnTemp.nextNode;
                }
                return i;
            }
            else
            {
                return 0;
            }
        }
        public virtual float getPosX()
        {
            return 0;
        }
        public virtual float getPosY()
        {
            return 0;
        }
        public virtual Status getStatus()
        {
            return currentStatus;
        }
        public virtual void setPos(float x, float y, float xOffset, float yOffset)
        {
            GameObjectTree columnTemp = activeColumns;
            int i = 0;
            while (columnTemp != null)
            {
                
                columnTemp.setPos((x + (columnTemp.getNum()*xOffset)),y,xOffset,yOffset);
                columnTemp = columnTemp.nextNode;
                i++;
            }
            setCollisionComponent();
        }
        public virtual float getLowestHeight()
        {
            return activeColumns.getLowestHeight();
        }
        public virtual void translate(float xOffset, float yOffset)
        {
            
            GameObjectTree columnTemp = activeColumns;
            int i = 0;
            //collisionComponent.setPosition(collisionComponent.getPosX() + xOffset, collisionComponent.getPosY() + yOffset);
            while (columnTemp != null)
            {

                columnTemp.translate(xOffset, yOffset);
                columnTemp = columnTemp.nextNode;
                i++;
            }
            setCollisionComponent();
        }
        public virtual void performLowest(int column){
            GameObjectTree temp = activeColumns;
            while (temp.nextNode != null && temp.getNum()!= column)
            {
                temp = temp.nextNode;
            }
            if (temp.getStatus() == Status.Active)
            {
                temp.performLowest(column);
            }
        }
        public virtual void removeFromActive(int num)
        {
            GameObjectTree columnTemp = activeColumns;
            GameObjectTree columnTempPrev = null;
            while (columnTemp != null && columnTemp.getNum() != num)
            {
                columnTempPrev = columnTemp;
                columnTemp = columnTemp.nextNode;
            }
            if (columnTemp != null)
            {
                if (columnTempPrev == null)
                {
                    activeColumns = activeColumns.nextNode;
                    columnTemp.nextNode = null;
                }
                else
                {
                    columnTempPrev.nextNode = columnTemp.nextNode;
                    columnTemp.nextNode = null;
                }
                if (reserveColumns == null)
                {
                    reserveColumns = columnTemp;
                }
                else
                {
                    columnTemp.nextNode = reserveColumns;
                    reserveColumns = columnTemp;
                }
            }
        }
        public virtual int getNum()
        {
            return -1;
        }
        public virtual bool isHit()
        {
            return false;
        }
        public virtual CollisionSprite getCollisionComponent()
        {
            return collisionComponent;
        }
        public virtual void setCollisionComponent()
        {
            GameObjectTree columnTemp = activeColumns;
            //columnTemp.setCollisionComponent();
            while (columnTemp != null && columnTemp.getStatus() != Status.Active)
            {
                columnTemp = columnTemp.nextNode;
            }
            if (columnTemp != null)
            {
                float smallX = columnTemp.getCollisionComponent().getPosX();
                float largeX = smallX;
                float width = columnTemp.getCollisionComponent().getWidth();
                float height = columnTemp.getCollisionComponent().getHeight();
                float y = columnTemp.getCollisionComponent().getPosY();
                columnTemp = columnTemp.nextNode;
                while (columnTemp != null)
                {
                    if (columnTemp.getStatus() == Status.Active)
                    {
                        if (height < columnTemp.getCollisionComponent().getHeight())
                        {
                            height = columnTemp.getCollisionComponent().getHeight();
                            y = columnTemp.getCollisionComponent().getPosY();
                        }
                        if (largeX < columnTemp.getCollisionComponent().getPosX())
                        {
                            largeX = columnTemp.getCollisionComponent().getPosX();
                        }
                        else if (smallX > columnTemp.getCollisionComponent().getPosX())
                        {
                            smallX = columnTemp.getCollisionComponent().getPosX();
                        }
                        columnTemp.getCollisionComponent();
                    }
                    else
                    {
                        Console.WriteLine("hi Tree");
                    }
                    columnTemp = columnTemp.nextNode;

                }

                collisionComponent.setTransformation(((largeX - smallX) / 2) + smallX, y, (largeX - smallX) + width, height);
            }
            else
            {
                currentStatus = Status.Inactive;
                collisionComponent.setStatus(Status.Inactive);
            }
        }
        public override bool acceptGridVisit(CollisionSprite visitor)
        {
            return collisionComponent.visitGrid(visitor);
        }
        public override ObjectController acceptGameObjectVisit(CollisionSprite visitor)
        {
            GameObjectTree columnTemp = activeColumns;
            
            while (columnTemp != null)
            {

                if (columnTemp.acceptGridVisit(visitor))
                {
                    return columnTemp.acceptGameObjectVisit(visitor);
                }
            }
            return null;
        }
        public virtual void checkGameObjectTreeCollision(GameObjectTree tree)
        {
            if (tree.getCollisionComponent().checkCollision(this.collisionComponent, tree.getCollisionComponent()))
            {
                GameObjectTree columnTemp = activeColumns;
                while (columnTemp != null)
                {
                    if (columnTemp.getStatus() == Status.Active)
                    {
                        columnTemp.checkGameObjectTreeCollision(tree);
                    }
                    columnTemp = columnTemp.nextNode;
                }
            }
        }
        public virtual void setAllActive(Status st)
        {
            this.currentStatus = st;
            collisionComponent.setStatus(st);
            GameObjectTree columnTemp = activeColumns;
            while (columnTemp != null)
            {
                columnTemp.setAllActive(st);
                columnTemp = columnTemp.nextNode;
            }
        }
        public virtual bool checkProjectileCollision(Projectile projectile)
        {
            if (projectile.getCollisionComponent().checkCollision(this.collisionComponent, projectile.getCollisionComponent()))
            {
                GameObjectTree columnTemp = activeColumns;
                while (columnTemp != null)
                {
                    if (columnTemp.getStatus() == Status.Active)
                    {
                        if (columnTemp.checkProjectileCollision(projectile))
                        {
                            return true;
                        }
                    }
                    columnTemp = columnTemp.nextNode;
                }
            }
            return false;
        }
    }
}
