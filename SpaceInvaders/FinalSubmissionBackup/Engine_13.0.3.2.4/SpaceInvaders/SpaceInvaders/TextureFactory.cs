using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class TextureFactory
    {
        protected Texture texture;
        protected Texture letterTexture;
        private static TextureFactory textureFactory;
        public static TextureFactory Texture_Factory(){
            if(textureFactory == null){
                textureFactory = new TextureFactory();
            }
            return textureFactory;
        }
        public Texture getTexture(SpriteType name)
        {
            switch (name)
            {
                case SpriteType.Letter:
                    return letterTex;
                default:
                    return tex;
            }
        }
        public Texture tex{
            get{
                if(texture == null){
                    texture = new Texture(new Azul.Texture("Space_Invaders_Aliens.tga"));
                }
                return texture;
            }
        }
        public Texture letterTex
        {
            get
            {
                if (letterTexture == null)
                {
                    letterTexture = new Texture(new Azul.Texture("Font.tga"));
                }
                return letterTexture;
            }
        }
    }
}
