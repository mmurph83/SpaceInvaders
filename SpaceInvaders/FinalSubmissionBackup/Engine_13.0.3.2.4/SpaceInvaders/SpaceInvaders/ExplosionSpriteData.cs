using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ExplosionSpriteData : DLink
    {
        CollisionRenderCommand command;
        public ExplosionSpriteData(CollisionRenderCommand command)
        {
            this.command = command;
        }
        public void setPos(float x, float y)
        {
            this.command.setPos(x,y);
        }
        public void setStatus(Status status)
        {
            this.command.setStatus(status);
        }
        public void addToReceiver()
        {
            Receiver.instance.addCommand(command);
        }
        public Status checkStatus()
        {
            return command.getStatus();
        }
    }
}
