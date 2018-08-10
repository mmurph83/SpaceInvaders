using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class AnimationManagerList
    {
        ALink head;
        static AnimationManagerList managerList = new AnimationManagerList();
        public AnimationManagerList()
        {
            addManager(AnimationFactory.makeAnimation(SpriteType.Crab));
            addManager(AnimationFactory.makeAnimation(SpriteType.Squid));
            addManager(AnimationFactory.makeAnimation(SpriteType.Bug));
        }
        public static AnimationManagerList instance
        {
            get
            {
                return managerList;
            }
        }
        public void addManager(AnimationManager manager)
        {
            if (head == null)
            {
                head = new AnimationDataNode(manager);
            }
            else
            {
                ALink temp = new AnimationDataNode(manager);
                temp.next = head;
                head = temp;
            }
        }
        public AnimationManager findManager(SpriteType name)
        {
            ALink temp = head;
            while (temp.next != null && ((AnimationDataNode)temp).getName() != name)
            {
                temp = temp.next;
            }
            return ((AnimationDataNode)temp).getManager();
        }
    }
}
