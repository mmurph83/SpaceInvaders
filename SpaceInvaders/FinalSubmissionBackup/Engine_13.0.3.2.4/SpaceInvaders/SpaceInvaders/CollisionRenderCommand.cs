using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CollisionRenderCommand : Command
    {
        Sprite sprite;
        public CollisionRenderCommand(Sprite sprite):base(0,300)
        {
            this.sprite = sprite;
        }
        public void setPos(float x, float y)
        {
            sprite.setPosition(x, y);
        }
        public void setStatus(Status status)
        {
            sprite.setStatus(status);
        }
        public override void execute()
        {
            this.setStatus(Status.Inactive);
        }
        public Status getStatus() {
            return sprite.getStatus();
        }
    }
}
