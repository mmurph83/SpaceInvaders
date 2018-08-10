using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Size : Rectangle
    {
        public Size(Azul.Rect rect)
            : base(rect)
        {
            this.rect = rect;
        }
    }
}
