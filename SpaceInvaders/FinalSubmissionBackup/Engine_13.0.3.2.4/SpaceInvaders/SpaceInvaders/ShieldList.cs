using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ShieldList
    {
        SLink head;
        
        public ShieldList(int totalShields)
        {
            if (totalShields > 0)
            {
                head = new ShieldDataNode(GameObjectTreeFactory.getFactory.makeGameObjectTreeShield(),0);
            }
            for (int i = 1; i < totalShields; i++)
            {
                SLink temp = new ShieldDataNode(GameObjectTreeFactory.getFactory.makeGameObjectTreeShield(),i);
                temp.next = head;
                head = temp;
            }
        }
        public void checkProjectileCollision(ProjectileManager manager)
        {
            SLink temp = head;
            while (temp != null)
            {
                manager.sendProjectiles(((ShieldDataNode)temp).getShield());
                temp = temp.next;
            }
        }
        public void setPos(float x, float y,float Xoffset, float Yoffset,int i)
        {
            SLink temp = head;
            while (temp != null && ((ShieldDataNode)temp).getNum() != i)
            {
                temp = temp.next;
            }
            if (temp != null)
            {
                ((ShieldDataNode)temp).getShield().setPos(x, y, Xoffset,Yoffset);
            }
        }
        public void checkAlienCollision(GameObjectTree tree)
        {
            SLink temp = head;
            while (temp != null)
            {
                ((ShieldDataNode)temp).getShield().checkGameObjectTreeCollision(tree);
                temp = temp.next;
            }
        }
        public void setAllActive(Status s)
        {
            SLink temp = head;
            while (temp != null)
            {
                ((ShieldDataNode)temp).getShield().setAllActive(s);
                temp = temp.next;
            }
        }
    }
}
