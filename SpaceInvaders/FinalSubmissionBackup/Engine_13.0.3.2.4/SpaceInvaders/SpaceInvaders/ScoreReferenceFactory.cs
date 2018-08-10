using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ScoreReferenceFactory
    {
        static ScoreReferenceFactory factory = new ScoreReferenceFactory();
        public static ScoreReferenceFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public int getScore(SpriteType name)
        {
            switch (name)
            {
                case SpriteType.Crab:
                    return 10;
                case SpriteType.Bug:
                    return 20;
                case SpriteType.Squid:
                    return 30;
                default:
                    return 100;
            }
        }
    }
}
