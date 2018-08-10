using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageManagerFactory
    {
        protected static ImageManagerFactory iMFactory = new ImageManagerFactory();
        public ImageManagerFactory()
        {
            
        }
        public static ImageManagerFactory instance
        {
            get
            {
                return iMFactory;
            }
        }
      
    }
}
