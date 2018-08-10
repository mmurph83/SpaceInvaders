using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProjectileController : Visitor
    {
        ProjectileManager playerProjectileManager;
        ProjectileManager enemyProjectileManager;
        public ProjectileController()
        {
            playerProjectileManager = new ProjectileManager();
            playerProjectileManager.setSpeed(TranslationSpeed.factory.getPlayerProjectile(), TranslationSpeed.factory.getPlayerProjectile());
            enemyProjectileManager = new ProjectileManager();
            enemyProjectileManager.setSpeed(TranslationSpeed.factory.getEnemyProjectile(), TranslationSpeed.factory.getEnemyProjectile());
        }
        public ProjectileController(ProjectileManager playerProjectileManager, ProjectileManager enemyProjectileManager)
        {
            this.playerProjectileManager = playerProjectileManager;
            playerProjectileManager.setSpeed(TranslationSpeed.factory.getPlayerProjectile(), TranslationSpeed.factory.getPlayerProjectile());
            this.enemyProjectileManager = enemyProjectileManager;
            enemyProjectileManager.setSpeed(TranslationSpeed.factory.getEnemyProjectile(), TranslationSpeed.factory.getEnemyProjectile());
        }
        public void deactiateProjectiles()
        {
            playerProjectileManager.assignAllToReserve();
            enemyProjectileManager.assignAllToReserve();
        }
        public void createEnemyProjectile(float x, float y)
        {
            if (enemyProjectileManager.getTotalReserve() == 0)
            {
                Projectile temp = ProjectileFactory.Instance.createEnemyProjectile();
                temp.setPos(x, y);
                enemyProjectileManager.addProjectile(temp);
            }
            else
            {
                Projectile temp = enemyProjectileManager.addProjectileToActive();
                temp.setStatus(Status.Active);
                temp.setPos(x, y);
            }
        }
        public void createPlayerProjectile(float x, float y)
        {
            if (playerProjectileManager.getTotalActive() == 0)
            {
                if (playerProjectileManager.getTotalReserve() == 0)
                {
                    Projectile temp = ProjectileFactory.Instance.createPlayerProjectile();
                    temp.setPos(x, y);
                    
                    playerProjectileManager.addProjectile(temp);
                }
                else
                {
                    Projectile temp = playerProjectileManager.addProjectileToActive();
                    temp.setStatus(Status.Active);
                    temp.setPos(x, y);
                }
            }
        }
        public void updateProjectiles()
        {
            playerProjectileManager.updatePos();
            enemyProjectileManager.updatePos();
        }
        public void checkShieldCollision(ShieldList l)
        {
            l.checkProjectileCollision(playerProjectileManager);
            l.checkProjectileCollision(enemyProjectileManager);
        }
        public void checkWallCollision(GridWallCollisionList g)
        {
            playerProjectileManager.checkWallCollision(g);
            enemyProjectileManager.checkWallCollision(g);
        }
        public void checkPlayerCollision(Player player)
        {
            enemyProjectileManager.checkPlayerCollision(player);
        }
        public void checkUFOCollision(Alien alien)
        {
            if (alien.getStatus() != Status.Inactive)
            {
                playerProjectileManager.checkUFOCollision(alien);
            }
        }
        public void checkManagerCollision()
        {
            enemyProjectileManager.checkProjectileManagerCollision(playerProjectileManager);
        }
        public ProjectileManager getPlayerManager()
        {
            return playerProjectileManager;
        }
        public ProjectileManager getEnemyManager()
        {
            return enemyProjectileManager;
        }
    }
}
