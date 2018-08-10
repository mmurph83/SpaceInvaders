using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class SpriteBatchRenderer : Manager
    {
        public SpriteBatchRenderer(): base(0)
        {

        }
        public void createActive(SpriteManager s) 
        {
            AddToActive(new SpriteManagerDataNode(s));
        }
        public void Update()
        {
            DLink renderTemp = this.pActive;
            while (renderTemp != null)
            {
                ((SpriteManagerDataNode)renderTemp).Update();
                renderTemp = renderTemp.pNext;
            }
        }
        public void Render()
        {

        }
    }
}
