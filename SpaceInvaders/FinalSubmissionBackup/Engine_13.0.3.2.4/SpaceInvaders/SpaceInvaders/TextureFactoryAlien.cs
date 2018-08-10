using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class TextureFactoryAlien :TextureFactory
    {
        private static TextureFactory textureFactory;
        public static TextureFactory Texture_Factory_Alien()
        {
            if (textureFactory == null)
            {
                textureFactory = new TextureFactoryAlien();
            }
            return textureFactory;
        }
        public Texture tex
        {
            get
            {
                if (texture == null)
                {
                    texture = new Texture(new Azul.Texture("Space_Invaders_Aliens.tga"));
                }
                return texture;
            }
        }
    }
}
