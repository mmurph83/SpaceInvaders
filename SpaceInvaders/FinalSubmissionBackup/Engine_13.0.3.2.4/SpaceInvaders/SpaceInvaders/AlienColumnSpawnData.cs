﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AlienColumnSpawnData : DLink
    {
        int column;
        public AlienColumnSpawnData(int column)
        {
            this.column = column;
        }
        public int getColumn()
        {
            return column;
        }
    }
}
