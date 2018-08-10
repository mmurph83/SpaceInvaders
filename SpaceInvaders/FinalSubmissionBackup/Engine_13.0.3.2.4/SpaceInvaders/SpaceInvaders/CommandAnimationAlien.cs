using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class CommandAnimationAlien : Command
    {
        ALink head;
        public CommandAnimationAlien(MovementController movement,long time, long timeOffset):base(time,timeOffset)
        {
            head = new AnimationDataNode(AnimationManagerList.instance.findManager(SpriteType.Crab));
            head.next = new AnimationDataNode(AnimationManagerList.instance.findManager(SpriteType.Squid));
            head.next.next = new AnimationDataNode(AnimationManagerList.instance.findManager(SpriteType.Bug));
        }
        public override void execute()
        {
            ALink temp = head;
            while (temp != null)
            {
                ((AnimationDataNode)temp).getManager().setAnimationToNextImage();
                Console.WriteLine(((AnimationDataNode)temp).getManager().getName());
                temp = temp.next;
            }
        }
    }
}
