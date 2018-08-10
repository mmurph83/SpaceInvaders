using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerBoundaryBoxRight:PlayerBoundaryBox
    {
        public PlayerBoundaryBoxRight(Player player, CollisionSprite boundaryBox)
            : base(player, boundaryBox)
        {

        }
        public override void checkPlayerState(){
            if (player.getMovementDirection() == Movement.Right)
            {
                player.setMovementState(MovementStateFactory.still);
            }
        }
    }
}
