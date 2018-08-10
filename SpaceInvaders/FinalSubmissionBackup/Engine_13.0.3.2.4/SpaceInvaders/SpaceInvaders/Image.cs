using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Image : Rectangle
    {
        public Image(Azul.Rect rect):base(){
            this.rect = rect;
        }
        public override  Azul.Rect getRect()
        {
            return this.rect;
        }
        public override void setRect(float x, float y, float width, float height)
        {
            this.rect.Set(x, y, width, height);
        }
        //name
        //texture
    }
}
