using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProjectileControllerFactory
    {
        ProjectileManager playerProjectile = new ProjectileManager();
        ProjectileManager enemyProjectile = new ProjectileManager();
        ProjectileController projectileController;
        static ProjectileControllerFactory projectileFactory = new ProjectileControllerFactory();
        public ProjectileControllerFactory()
        {
            projectileController = new ProjectileController(playerProjectile, enemyProjectile);
        }
        public static ProjectileControllerFactory instance
        {
            get
            {
                return projectileFactory;
            }
        }
        public ProjectileManager player
        {
            get
            {
                return playerProjectile;
            }
        }
        public ProjectileManager enemy
        {
            get
            {
                return enemyProjectile;
            }
        }
        public ProjectileController controller
        {
            get
            {
                return projectileController;
            }
        }
    }
}
