using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class SizeFactory
    {
        private Size size = new Size(new Azul.Rect(0,0,30,30));
        private Size baseSize = new Size(new Azul.Rect(1, 1, 1, 1));
        private static SizeFactory sizeFactory = new SizeFactory();
        static Scale alien;
        static Scale shield;
        static Scale player;
        static Scale playerBoundary;
        static Scale playerProjectile;
        static Scale enemyProjectile;
        static Scale letter;
        public static SizeFactory getFactory
        {
            get
            {
                return sizeFactory;
            }
        }
        public SizeFactory()
        {
            alien = new Scale();
            alien.spriteWidth = 60;
            alien.spriteHeight = 60;
            alien.colWidth = alien.spriteWidth/1.5f;
            alien.colHeight = alien.spriteHeight/1.5f;
            shield = new Scale();
            shield.spriteWidth = 13;
            shield.spriteHeight = 7f;
            shield.colWidth = shield.spriteWidth;
            shield.colHeight = shield.spriteHeight;
            player = new Scale();
            player.spriteWidth = 30;
            player.spriteHeight = 30;
            player.colWidth = 35;
            player.colHeight = 15;
            playerBoundary = new Scale();
            playerBoundary.spriteWidth = 10;
            playerBoundary.spriteHeight = 10;
            playerBoundary.colWidth = 10;
            playerBoundary.colHeight = 10;
            playerProjectile = new Scale();
            playerProjectile.spriteWidth = 5f;
            playerProjectile.spriteHeight = 25f;
            
            playerProjectile.colWidth = 5f;
            playerProjectile.colHeight = 30f;

            enemyProjectile = new Scale();
            enemyProjectile.spriteWidth = 5f;
            enemyProjectile.spriteHeight = 25f;

            enemyProjectile.colWidth = 5f;
            enemyProjectile.colHeight = 25f;
            letter = new Scale();
            letter.spriteWidth = 25f;
            letter.spriteHeight = 25f;

            letter.colWidth = 25f;
            letter.colHeight = 25f;
        }
        
        /*public static SizeFactory Size_Factory()
        {
            if (sizeFactory == null)
            {
                sizeFactory = new SizeFactory();
            }
            return sizeFactory;
        }*/
        public Scale playerP
        {
            get
            {
                return playerProjectile;
            }
        }
        public Scale enemyP
        {
            get
            {
                return enemyProjectile;
            }
        }
        public Size s
        {
            get
            {
                return size;
            }
        }
        public  Size baseS{
            get
            {
                return baseSize;
            }
         }
        public Scale alienScale
        {
            get
            {
                return alien;
            }
        }
        public  Scale shieldScale
        {
            get
            {
                return shield;
            }
        }
        public Scale playerScale
        {
            get
            {
                return player;
            }
        }
        public Scale boundaryScale
        {
            get
            {
                return playerBoundary;
            }
        }
        public Scale letterScale
        {
            get
            {
                return letter;
            }
        }
    }
    public struct Scale
    {
        public float spriteWidth;
        public float spriteHeight;
        public float colWidth;
        public float colHeight;
    }
}
