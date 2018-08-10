using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class CommandProjectileSpawn :Command
    {
        MovementController movement;
        DLink timeOffsetHead;
        DLink currentTime;
        DLink alienColumnHead;
        DLink currentColumn;
        public CommandProjectileSpawn(MovementController movement)
            : base(0,0)
        {
            this.movement = movement;
        }
        public void addColumn(int col)
        {
            DLink temp = new AlienColumnSpawnData(col);
            if (alienColumnHead == null)
            {
                alienColumnHead = temp;
                currentColumn = alienColumnHead;
            }
            else
            {
                temp.pNext = alienColumnHead;
                alienColumnHead = temp;
            }
        }
        public void addOffset(long t)
        {
            DLink temp = new TimeOffsetData(t);
            if (timeOffsetHead == null)
            {
                this.timeOffsetHead = temp;
                currentTime = timeOffsetHead;
            }
            else
            {
                temp.pNext = timeOffsetHead;
                timeOffsetHead = temp;
            }
        }
        public void addToReceiver()
        {
            
            currentColumn = currentColumn.pNext;
            currentTime = currentTime.pNext;
            if (currentColumn == null)
            {
                currentColumn = alienColumnHead;
            }
            if (currentTime == null)
            {
                currentTime = timeOffsetHead;
            }

            Receiver.instance.addCommand(this);
        }
        public override void execute()
        {
            movement.fireProjectile(this);
        }
        public int getColumnNum()
        {
            return ((AlienColumnSpawnData)currentColumn).getColumn();
        }
        public override long getTimeOffset()
        {
            return ((TimeOffsetData)currentTime).getOffset();
        }
    }
}
