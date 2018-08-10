using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    
    public static class ConstructionTotal
    {
        const int columnAlien = 11;
        const int totalBug = 1;
        const int totalSquid = 1;
        const int totalCrab = 1;
        public static int totalColumnAlien
        {
            get
            {
                return columnAlien;
            }
        }
        public static int getTotalAlien(SpriteType name)
        {
            int returnVal = 0;
            switch (name)
            {
                case SpriteType.Bug:
                    returnVal = totalBug;
                    break;
                case SpriteType.Squid:
                    returnVal = totalSquid;
                    break;
                case SpriteType.Crab:
                    returnVal = totalCrab;
                    break;
            }
            return returnVal;
        }
    }
}
