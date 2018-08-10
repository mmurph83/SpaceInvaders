using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerBoundaryBoxLeft : PlayerBoundaryBox
    {
        public PlayerBoundaryBoxLeft(Player player, CollisionSprite boundaryBox)
            : base(player,boundaryBox)
        {
            
        }
        public override void checkPlayerState(){
            if (player.getMovementDirection() == Movement.Left)
            {
                player.setMovementState(MovementStateFactory.still);
            }
        }
    }
}
