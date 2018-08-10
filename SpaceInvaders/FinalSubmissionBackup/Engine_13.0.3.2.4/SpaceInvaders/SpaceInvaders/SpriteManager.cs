using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class SpriteManager : Manager
    {
        SpriteBase sprite;
        private bool canRender = true;
        public SpriteManager(SpriteBase sprite) : base(0)
        {
            this.sprite = sprite;
            this.spriteName = sprite.getName();
        }
        public SpriteManager(SpriteType name)
            : base(0)
        {
            this.spriteName = name;
        }
        public void createActive(Sprite sprite){
            AddToActive(new SpriteDataNode(sprite, spriteName));
        }
        public void createActive(CollisionSprite sprite)
        {
            AddToActive(new SpriteDataNode(sprite, spriteName));
        }

        protected override void AddToActive(DLink newActive)
        {
            this.active++;
            //((SpriteDataNode)newActive).sprite.setSprite(sprite);
            if (this.pActive == null)
            {
                this.pActive = newActive;
                newActive.pNext = null;
                newActive.pPrev = null;
            }
            else
            {
                AddToHead(ref this.pActive, newActive);
            }
        }
        public void setRender()
        {
            this.canRender = !this.canRender;
        }
        public void Render()
        {
            if (canRender)
            {
                DLink renderTemp = this.pActive;
                while (renderTemp != null)
                {
                    ((SpriteDataNode)renderTemp).sprite.Render();
                    renderTemp = renderTemp.pNext;
                }
            }
        }
        public void Update()
        {
            if (canRender)
            {
                DLink renderTemp = this.pActive;
                while (renderTemp != null)
                {
                    ((SpriteDataNode)renderTemp).sprite.Update();
                    renderTemp = renderTemp.pNext;
                }
            }
        }
    }
}
