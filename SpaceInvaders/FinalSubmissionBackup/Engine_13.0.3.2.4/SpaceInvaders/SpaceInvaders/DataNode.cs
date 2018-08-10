using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class DataNode : DLink
    {
        public int x;
        public DataNode( int val )
            : base()
        {
            this.Set(val);
        }
        public DataNode()
            : base()
        {

        }

        public void Set(int val)
        {
            
            this.x = val;
        }

       

    // Data: --------------------------------
    

    }
    
    public enum SpriteType { Bug, Crab, Squid,UFO, Size, Image, Alien,Player, PlayerProjectile,EnemyProjectile, Projectile, Shield,Letter,Wall,Victory, Explosion, Unitialized}
}
