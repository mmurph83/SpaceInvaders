using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class TranslationSpeed
    {
        static float playerProjectile = 12f;
        static float enemyProjectile = 3f;
        static float player = 5f;
        static float baseGrid = 3f;
        static TranslationSpeed instance = new TranslationSpeed();
        
        public static TranslationSpeed factory
        {
            get
            {
                return instance;
            }
        }
        public float getPlayerProjectile()
        {
            return playerProjectile;
        }
        public float getEnemyProjectile()
        {
            return enemyProjectile;
        }
        public float getPlayerSpeed()
        {
            return player;
        }
        public float getAlienSpeed()
        {
            return baseGrid;
        }
    }
}
