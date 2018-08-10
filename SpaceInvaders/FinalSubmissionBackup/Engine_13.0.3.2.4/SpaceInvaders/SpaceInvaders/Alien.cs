using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Alien : ObjectController
    {
        public int score;
        public Alien(GameObject gameobject, int score)
            : base(gameobject)
        {
            this.score = score;
        }
        public override void notifyHit()
        {
            gameObject.setStatus(Status.Inactive);
            CollisionSpawnFactory.getFactory.spawnExplosion(gameObject.getPosX(), gameObject.getPosY());
            PlayScoreControllerFactory.getFactory.playController.addScore(score);
        }
        public override void setStatus(Status status)
        {
            gameObject.setStatus(status);
        }
        public override void perform()
        {
            ProjectileControllerFactory.instance.controller.createEnemyProjectile(getPosX(), getPosY());
        }
       
    }
}
