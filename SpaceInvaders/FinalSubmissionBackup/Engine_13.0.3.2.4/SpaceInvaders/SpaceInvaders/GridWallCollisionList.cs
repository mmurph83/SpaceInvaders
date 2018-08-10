using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GridWallCollisionList : CollisionList
    {
        CLink headCollisionTests;
        public GridWallCollisionList()
        {

        }

        public override bool checkCollision()
        {
            return base.checkCollision();
        }
        public override void acceptGridCollisionSubject(AlienGridCollisionSubject subject)
        {
            subject.visit(this);
        }
        public override void accpetPlayerCollision(Player player)
        {
            player.visit(this);
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
        public bool checkCollision(CollisionSprite sprite)
        {
            CLink temp = headCollisionTests;
            while (temp != null)
            {
                if(sprite.checkCollision(sprite,((WallCollisionData)temp).getCol())){
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        
    }
}
