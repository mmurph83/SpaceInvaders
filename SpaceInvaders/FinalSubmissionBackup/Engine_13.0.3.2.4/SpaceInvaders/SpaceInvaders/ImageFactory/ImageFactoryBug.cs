﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageFactoryBug 
    {
        private static Image image_001 = new Image(new Azul.Rect(0f, 1024f, 128f, -128f));
        private static Image image_002 = new Image(new Azul.Rect(128f, 1024f, 128f, -128f));
        private static ImageFactoryBug imageFactory = new ImageFactoryBug();
        public static ImageFactoryBug Instance
        {
            get
            {
                return imageFactory;
            }
        }
        public Image getImage(int num)
        {
            switch (num)
            {
                case 0:
                    return image_001;
                default:
                    return image_002;

            }
        }
    }
}
