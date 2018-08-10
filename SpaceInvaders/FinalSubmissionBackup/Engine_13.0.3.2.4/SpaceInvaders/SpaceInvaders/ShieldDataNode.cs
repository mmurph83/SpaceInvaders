using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ShieldDataNode : SLink
    {
        GameObjectTree tree;
        int num;
        public ShieldDataNode(GameObjectTree tree, int num)
        {
            this.tree = tree;
            this.num = num;
        }
        public GameObjectTree getShield()
        {
            return tree;
        }
        public int getNum()
        {
            return num;
        }
    }
}
