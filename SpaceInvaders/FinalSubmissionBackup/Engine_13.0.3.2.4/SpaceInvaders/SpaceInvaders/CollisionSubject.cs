using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionSubject : Visitor
    {
        DLink collidibleComponents;
        protected OLink headObservers;
        protected SpriteType name;
        public CollisionSubject(SpriteType name)
        {
            this.name = name;
        }
        public void addObserver(CollisionObserver colObserver)
        {
            if (headObservers == null)
            {
                headObservers = new ObserverData(colObserver);
            }
            else
            {
                OLink temp = new ObserverData(colObserver);
                temp.next = headObservers;
                headObservers = temp;
            }
        }
        public virtual void checkCollision()
        {

        }
        protected virtual void notifyObsevers(SpriteType name)
        {

        }
    }
}
