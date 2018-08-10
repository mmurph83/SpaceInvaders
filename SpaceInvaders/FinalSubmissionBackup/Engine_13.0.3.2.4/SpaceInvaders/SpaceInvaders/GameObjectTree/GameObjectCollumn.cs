using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class GameObjectColumn : GameObjectTree
    {
        int columnNum = 0;
        public GameObjectColumn(int columnNum):base()
        {
            this.columnNum = columnNum;
        }
        public override void AddToActive(int column, int row, ObjectController gameObject)
        {
            if (this.activeColumns == null)
            {
                activeColumns = new GameObjectNode(row);
                ((GameObjectNode)activeColumns).setObj(gameObject);
            }
            else
            {
                GameObjectTree columnTemp = activeColumns;
                while (columnTemp.nextNode != null && columnTemp.getNum() != row)
                {
                    columnTemp = columnTemp.nextNode;
                }
              
                    columnTemp.nextNode = new GameObjectNode(row);
                    columnTemp = columnTemp.nextNode;

               
                ((GameObjectNode)columnTemp).setObj(gameObject);
            }
        }
        public override float getPosX()
        {
            return activeColumns.getPosX();
        }
        public override float getPosY()
        {
            return 0;
        }
        public override void setPos(float x, float y, float xOffset, float yOffset)
        {
            GameObjectTree columnTemp = activeColumns;
            int i = 0;
            while (columnTemp != null)
            {

                columnTemp.setPos(x, (y + (columnTemp.getNum() * yOffset)), xOffset, yOffset);
                columnTemp = columnTemp.nextNode;
                i++;
            }
            setCollisionComponent();
        }
        public override void translate(float xOffset, float yOffset)
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
        public override void removeFromActive(int num)
        {

        }
        public override int getNum()
        {
            return columnNum;
        }
        public override void performLowest(int column)
        {
            GameObjectTree temp = activeColumns;
            while (temp != null && temp.getStatus() == Status.Inactive)
            {
                temp = temp.nextNode;
            }
            GameObjectTree check = temp;
            while (temp != null)
            {
                if(temp.getStatus() == Status.Active){
                    if (temp.getPosY() < check.getPosY())
                    {
                        check = temp;
                    }
                }
                temp = temp.nextNode;
            }
            if (check != null)
            {
                check.performLowest(column);
            }
        }
        public override CollisionSprite getCollisionComponent()
        {
            return collisionComponent;
        }
        public override void setCollisionComponent()
        {
            
            GameObjectTree columnTemp = activeColumns;
            while (columnTemp != null && columnTemp.getStatus() != Status.Active)
            {
                columnTemp = columnTemp.nextNode;
            }
            if (columnTemp != null)
            {
                float x = columnTemp.getCollisionComponent().getPosX();
                float width = columnTemp.getCollisionComponent().getWidth();
                float height = columnTemp.getCollisionComponent().getHeight();
                float lowY = columnTemp.getCollisionComponent().getPosY();
                float highY = columnTemp.getCollisionComponent().getPosY();
                columnTemp = columnTemp.nextNode;
                while (columnTemp != null)
                {
                    if (columnTemp.getStatus() == Status.Active)
                    {
                        if (lowY > columnTemp.getCollisionComponent().getPosY())
                        {
                            lowY = columnTemp.getCollisionComponent().getPosY();
                        }
                        else if (highY < columnTemp.getCollisionComponent().getPosY())
                        {
                            highY = columnTemp.getCollisionComponent().getPosY();
                        }
                        columnTemp.getCollisionComponent();
                    }
                    else
                    {
                        Console.WriteLine("hi");
                    }
                    columnTemp = columnTemp.nextNode;

                }
                collisionComponent.setTransformation(x, ((highY - lowY) / 2) + lowY, width, (highY - lowY) + height);
            }
            else
            {
                collisionComponent.setStatus(Status.Inactive);
                currentStatus = Status.Inactive;
                
            }
        }
    }
}
