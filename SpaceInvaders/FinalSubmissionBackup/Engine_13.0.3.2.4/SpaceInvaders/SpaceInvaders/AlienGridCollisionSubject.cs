using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AlienGridCollisionSubject : CollisionSubject
    {
        GameObjectTree tree;
        CLink headCollisionTests;
        //OLink headObservers;
        bool canNotify = false;
        public AlienGridCollisionSubject(GameObjectTree tree, SpriteType name):base(name)
        {
            this.tree = tree;
        }
        public void addCollisionTest(CollisionSprite col)
        {
            if (headCollisionTests == null)
            {
                headCollisionTests = new WallCollisionData(col);
            }
            else
            {
                CLink temp = new WallCollisionData(col);
                temp.next = headCollisionTests;
                headCollisionTests = temp;
            }
        }
        
        public override void checkCollision()
        {
            CLink temp = headCollisionTests;
            while (temp != null)
            {
                if(tree.acceptGridVisit(((WallCollisionData)temp).getCol())){
                    notifyObsevers(((WallCollisionData)temp).getName());
                    return;
                }
                temp = temp.next;
            }
            notifyObsevers(SpriteType.Unitialized);
        }
        protected override void notifyObsevers(SpriteType name)
        {
            OLink temp = headObservers;
            while (temp != null)
            {
                ((ObserverData)temp).getObserver().notifyCollisionType(name);
                temp = temp.next;
            }
        }
        public override void visit(GridWallCollisionList grid)
        {
            if (grid.checkCollision(tree.getCollisionComponent()))
            {
                
                notifyObsevers(SpriteType.Wall);
                canNotify = true;
            }
            else if (canNotify)
            {
                notifyObsevers(SpriteType.Shield);
                canNotify = false;
            }
        }
    }
}
