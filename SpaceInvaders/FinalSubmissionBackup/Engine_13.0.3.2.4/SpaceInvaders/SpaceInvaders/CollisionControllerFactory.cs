using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionControllerFactory
    {
        ShieldCollisionController shieldCol;
        AlienCollisionController alienCol;
        WallCollisionController wallCol;
        PlayerCollisionController playerCol;
        ProjectileCollisionController projectileCol;
        GridSubjectCollisionController alienSubjectCol;
        UFOCollisionController ufoCol;
        CollisionIterator it;
        GridSubjectCollisionController alienVictoryCol;
        static CollisionControllerFactory factory = new CollisionControllerFactory();
        public CollisionControllerFactory()
        {
            shieldCol = new ShieldCollisionController(ShieldListFactory.getFactory.getShieldList());
            alienCol = new AlienCollisionController(MovementControllerFactory.getFactory.getController());
            wallCol = new WallCollisionController(GridWallCollisionListFactory.getFactory().getList());
            playerCol = new PlayerCollisionController(PlayerInputControllerFactory.getFactory.getController());
            projectileCol = new ProjectileCollisionController(ProjectileControllerFactory.instance.controller);
            alienSubjectCol = new GridSubjectCollisionController(CollisionSubjectFactory.getFactory.getAlienSubject());
            alienVictoryCol = new GridSubjectCollisionController(CollisionSubjectFactory.getFactory.getAlienVictorySubject());
            ufoCol = new UFOCollisionController(UFOSpawnControllerFactory.getFactory.getController);

            colSetup();
        }
        void colSetup()
        {
            shieldCol.addCollision(projectileCol);
            wallCol.addCollision(projectileCol);
            playerCol.addCollision(projectileCol);
            alienCol.addCollision(projectileCol);
            alienCol.addCollision(alienVictoryCol);
            //projectileCol.addCollision(alienCol);
            //playerCol.addCollision(wallCol);
            wallCol.addCollision(playerCol);
            wallCol.addCollision(alienSubjectCol);
            shieldCol.addCollision(alienCol);
            projectileCol.addCollision(projectileCol);
            projectileCol.addCollision(ufoCol);
            it = new CollisionIterator();
            it.addCollision(shieldCol);
            it.addCollision(alienCol);
            it.addCollision(wallCol);
            it.addCollision(playerCol);
            it.addCollision(projectileCol);
        }
        public static CollisionControllerFactory getFactor
        {
            get
            {
                return factory;
            }
        }
        public ShieldCollisionController getShield
        {
            get
            {
                return shieldCol;
            }
        }
        public AlienCollisionController getAlien
        {
            get
            {
                return alienCol;
            }
        }
        public WallCollisionController getWall
        {
            get
            {
                return wallCol;
            }
        }
        public PlayerCollisionController getPlayer
        {
            get
            {
                return playerCol;
            }
        }
        public ProjectileCollisionController getProject
        {
            get
            {
                return projectileCol;
            }
        }
        public CollisionIterator getIterator
        {
            get
            {
                return it;
            }
        }
    }
}
