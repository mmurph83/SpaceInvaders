using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ShieldListFactory
    {
        ShieldList list;
        static ShieldListFactory factory = new ShieldListFactory();
        public static ShieldListFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public ShieldList getShieldList()
        {
            return list;
        }
        public ShieldListFactory()
        {
            list = new ShieldList(4);
        }
    }
}
