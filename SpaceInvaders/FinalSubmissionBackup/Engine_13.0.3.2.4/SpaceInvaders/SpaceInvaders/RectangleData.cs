using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class RectangleData : DataNode
    {
        public Rectangle rect;
        public RectangleData( int num, Rectangle rect)
            : base(num)
        {
            this.rect = rect;
            this.Set(num);
        }
        public RectangleData() : base()
        {

        }
        public Azul.Rect getRect()
        {
            return rect.getRect();
        }
    }
}
