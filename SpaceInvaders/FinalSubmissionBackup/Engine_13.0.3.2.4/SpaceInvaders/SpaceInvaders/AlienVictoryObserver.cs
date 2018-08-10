using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AlienVictoryObserver : CollisionObserver
    {
        
        GameController controller;
     
        public AlienVictoryObserver()
        {
            this.controller = GameControllerFactory.getFactory.c;
        }
        public AlienVictoryObserver(GameController controller)
        {
            
        }
        public override void notifyCollisionType(SpriteType name)
        {
            if (name == SpriteType.Victory)
            {
              
                    //controller.setState(GameMode.Start);
                    GameControllerFactory.getFactory.c.setState(GameMode.Start);

            }
            
        }
    }
}
