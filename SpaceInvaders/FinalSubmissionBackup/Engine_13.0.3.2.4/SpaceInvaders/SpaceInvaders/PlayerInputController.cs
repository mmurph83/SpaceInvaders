using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerInputController
    {
        Player player;
        ProjectileController projectileController = ProjectileControllerFactory.instance.controller;
        float speed = 1f;
        public PlayerInputController(Player player)
        {
            this.player = player;
            speed = TranslationSpeed.factory.getPlayerSpeed();
        }
        public void setProjectileController(ProjectileController projectileController)
        {
            this.projectileController = projectileController;
        }
        public void checkInput()
        {
            if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_ARROW_LEFT) || Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_ARROW_RIGHT))
            {
                if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_ARROW_LEFT) && (player.getMovementDirection() == Movement.Stationary || !Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_ARROW_RIGHT)))
                {
                    if (player.canMoveLeft())
                    {
                        player.setMovementState(MovementStateFactory.left);
                    }
                }
                else if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_ARROW_RIGHT) && (player.getMovementDirection() == Movement.Stationary || !Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_ARROW_LEFT)))
                {
                    if (player.canMoveRight())
                    {
                        player.setMovementState(MovementStateFactory.right);
                    }
                }
            }
            else
            {
                player.setMovementState(MovementStateFactory.still);
            }
            if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_SPACE))
            {
                projectileController.createPlayerProjectile(player.getPosX(),player.getPosY());
            }
        }
        public Player getPlayer()
        {
            return player;
        }
        public void translate()
        {
            if (player.getStatus() == Status.Active)
            {
                player.translate(speed, 0);
            }
        }
        public void checkWallCollision(GridWallCollisionList col)
        {
            player.visit(col);
        }
    }
}
