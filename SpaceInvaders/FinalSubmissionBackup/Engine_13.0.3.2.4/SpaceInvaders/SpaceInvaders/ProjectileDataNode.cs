using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class ProjectileDataNode : DLink
    {
        Projectile projectile;
        public ProjectileDataNode(Projectile projectile)
        {
            this.projectile = projectile;
        }
        public void setPos(float x, float y)
        {
            projectile.setPos(x, y);
        }
        public void translate(float xOffset, float yOffset)
        {
            projectile.translate(xOffset, yOffset);
        }
        public Projectile getProjectile()
        {
            return projectile;
        }
    }
}
