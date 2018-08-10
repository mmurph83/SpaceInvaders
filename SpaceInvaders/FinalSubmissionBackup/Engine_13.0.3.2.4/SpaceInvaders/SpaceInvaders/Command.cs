using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Command
    {
        public Command next;
        public Command prev;
        protected long time;
        protected long timeOffset;
        public Command(long time, long timeOffset)
        {
            this.time = time;
            this.timeOffset = timeOffset;
        }
        public void setTime(long time)
        {
            this.time = time;
        }
        public void setTimeOffset(long timeOffset)
        {
            this.timeOffset = timeOffset;
        }
        public virtual long getTimeOffset()
        {
            return timeOffset;
        }
        public long getTime()
        {
            return time;
        }
        public virtual void execute()
        {

        }
    }
}
