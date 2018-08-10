using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AlienVictoryCollisionSubject : CollisionSubject
    {
        CollisionSprite colSprite;
        public AlienVictoryCollisionSubject(CollisionSprite colSprite,SpriteType name) : base(name)
        {
            this.colSprite = colSprite;
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
        public override void visit(MovementController controller) {
            if (colSprite.checkCollision(colSprite,controller.getTree().getCollisionComponent()))
            {
                notifyObsevers(SpriteType.Victory);
            }
        }
        public void setPos(float x, float y)
        {
            this.colSprite.setPosition(x, y);
        }
        public void setScale(float width, float height)
        {
            this.colSprite.setScale(width, height);
        }
    }
}
