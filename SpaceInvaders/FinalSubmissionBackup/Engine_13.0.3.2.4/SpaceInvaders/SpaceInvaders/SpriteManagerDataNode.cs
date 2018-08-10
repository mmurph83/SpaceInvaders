using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class SpriteManagerDataNode : SpriteBatchRenderData
    {
        SpriteManager sManager;
        SpriteType name;
        public SpriteManagerDataNode(SpriteManager sManager)
        {
            this.sManager = sManager;
            this.name = sManager.getName();
        }
        public override void Update()
        {
            sManager.Update();
        }
        
    }
}
