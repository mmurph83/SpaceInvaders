using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameState
    {
        protected bool isLoaded = false;
        public virtual void Load()
        {

        }
        public virtual void Update()
        {

        }
        public virtual void Render()
        {

        }
        public virtual void UnLoad()
        {

        }
        public virtual void reset()
        {

        }
    }
}
