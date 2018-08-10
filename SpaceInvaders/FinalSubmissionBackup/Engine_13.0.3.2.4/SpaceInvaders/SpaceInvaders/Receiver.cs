using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Receiver
    {
        Command command;
        static Receiver receiver = new Receiver();
        public static Receiver instance
        {
            get
            {
                return receiver;
            }
        }
        public void execute()
        {
            Command temp = command;
            while (command != null && command.getTime() < TimerManager.instance.getCurrentTime())
            {
                command = command.next;
                if (temp.next != null)
                {
                    temp.next.prev = null;
                    
                }
                else
                {
                    command = null;
                }
                temp.next = null;
                temp.prev = null;
                temp.execute();
                temp = command;
            }
        }
        public void clearTime()
        {
            Command temp = command;
            while (command != null)
            {
                command = command.next;
                
                temp.next = null;
                temp.prev = null;
            }
        }
        public void addCommand(Command c)
        {
            if (c.next == null)
            {
                c.prev = null;
                c.setTime(c.getTimeOffset() + TimerManager.instance.getCurrentTime());
                if (command == null)
                {
                    command = c;
                }
                else
                {
                    //c.setTime(c.getTimeOffset()+ TimerManager.instance.getCurrentTime());
                    Command temp = command;
                    if (command.getTime() > c.getTime())
                    {
                        c.next = command;
                        command.prev = c;
                        command = c;
                        command.prev = null;
                    }
                    else
                    {
                        while (temp.getTime() <= c.getTime() && temp.next != null)
                        {
                            temp = temp.next;
                        }
                        if (temp.getTime() <= c.getTime())
                        {
                            temp.next = c;
                            c.prev = temp;
                        }
                        else
                        {
                            c.prev = temp.prev;
                            c.next = temp;
                            if (c.prev != null)
                            {
                                c.prev.next = c;
                            }
                            temp.prev = c;
                        }
                    }
                }
            }
        }
    }
}
