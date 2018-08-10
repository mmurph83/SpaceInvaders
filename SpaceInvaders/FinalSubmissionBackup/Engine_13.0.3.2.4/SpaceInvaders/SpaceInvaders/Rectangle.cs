using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Rectangle
    {
        
        public Azul.Rect rect;
        public Rectangle(Azul.Rect rect)
        {
            this.rect = rect;
        }
        public Rectangle()
        {

        }
        public virtual Azul.Rect getRect(){
            return rect;
        }
        public virtual void setRect(float x, float y, float width, float height)
        {
            this.rect.x = x;
            this.rect.y = y;
            this.rect.width = width;
            this.rect.height = height;
        }
    }
}
