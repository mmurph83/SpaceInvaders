using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Color
    {
        Azul.Color color;
        public Color(Azul.Color col)
        {
            this.color = col;
        }
        public Azul.Color getColor()
        {
            return color;
        }
    }
}
