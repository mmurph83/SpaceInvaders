using System.Diagnostics;

namespace SpaceInvaders
{
    public class TimerManager
    {
        Stopwatch timer;
        long currentTime;
        long previousTime = 0;
        public static TimerManager manager = new TimerManager();
        public static TimerManager instance
        {
            get
            {
                return manager;
            }
        }
        public TimerManager()
        {
            timer = Stopwatch.StartNew();
        }
        public void updateTime()
        {
            previousTime = currentTime;
            currentTime = timer.ElapsedMilliseconds;
            
        }
        public long getCurrentTime()
        {
            return currentTime;
        }
    }
}
