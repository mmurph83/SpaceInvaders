using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ColorFactory
    {

        Color white;
        Color green;
        Color red;
        Color blue;
        static ColorFactory colFactory = new ColorFactory();
        public ColorFactory()
        {
            white = new Color(new Azul.Color(1, 1, 1, 1));
            green = new Color(new Azul.Color(0, 1, 0, 1));
            red = new Color(new Azul.Color(1, 0, 1, 1));
            blue = new Color(new Azul.Color(0, 1, 1, 1));
        }
        public static ColorFactory instance
        {
            get
            {
                return colFactory;
            }
        }
        public Color w
        {
            get
            {
                return white;
            }
        }
        public Color g
        {
            get
            {
                return green;
            }
        }
        public Color r
        {
            get
            {
                return red;
            }
        }
        public Color b
        {
            get
            {
                return blue;
            }
        }
    }
}
