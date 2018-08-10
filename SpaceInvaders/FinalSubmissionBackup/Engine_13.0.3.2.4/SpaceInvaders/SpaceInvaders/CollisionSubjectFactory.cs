using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    
    public class CollisionSubjectFactory
    {
        AlienGridCollisionSubject alien;
        AlienVictoryCollisionSubject alienVictory;
        static CollisionSubjectFactory factory = new CollisionSubjectFactory();
        public static CollisionSubjectFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public CollisionSubjectFactory()
        {
            alien = new AlienGridCollisionSubject(GameObjectTreeFactory.getFactory.alien, SpriteType.Unitialized);
            alien.addObserver(new MovementCollisionObserver(MovementControllerFactory.getFactory.getController()));
            alienVictory = new AlienVictoryCollisionSubject(ProxySpriteCollisionFactory.proxy,SpriteType.Unitialized);
            alienVictory.addObserver(new AlienVictoryObserver(GameControllerFactory.getFactory.c));
        }
        public AlienGridCollisionSubject getAlienSubject()
        {
            return alien; 
        }
        public AlienVictoryCollisionSubject getAlienVictorySubject()
        {
            return alienVictory;
        }
        
    }
}
