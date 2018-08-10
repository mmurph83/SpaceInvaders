using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class TimeOffsetData : DLink
    {
        long timeOffset = 0;
        public TimeOffsetData(long timeOffset)
        {
            this.timeOffset = timeOffset;
        }
        public long getOffset()
        {
            return timeOffset;
        }
    }
}
