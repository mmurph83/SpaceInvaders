using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Texture
    {
        Azul.Texture texture;
        public Texture(Azul.Texture text)
        {
            this.texture = text;
        }
        public Azul.Texture getTexture()
        {
            return texture;
        }
    }
}
