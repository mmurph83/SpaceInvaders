using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerStatusController : Manager
    {
        bool isMultiplayer = true;
        bool allActive = false;
        DLink currentPlayer;
        
        public void createNewPlayers(int totalPlayers)
        {
            if (active < totalPlayers)
            {
                totalPlayers = totalPlayers - active;
                for (int i = 0; i < totalPlayers; i++)
                {
                    AddToActive(new PlayerStatus(active));
                }
            }
            currentPlayer = pActive;
        }
       
        public void setToNextPlayer()
        {
            if (isMultiplayer)
            {
                currentPlayer = currentPlayer.pNext;
                if (currentPlayer == null)
                {
                    currentPlayer = pActive;
                }
            }
        }
        public float getCurrentX()
        {
            return ((PlayerStatus)currentPlayer).getX();
        }
        public float getCurrentY()
        {
            return ((PlayerStatus)currentPlayer).getY();
        }
        public void setAllPos(float x, float y)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                ((PlayerStatus)temp).setX(x);
                ((PlayerStatus)temp).setY(y);
                temp = temp.pNext;
            }
        }
        public void setCurrentY(float y)
        {
            ((PlayerStatus)currentPlayer).setY(y);
        }
        public void checkCurrentStatus()
        {
            ((PlayerStatus)currentPlayer).checkManager();
        }
        public void setCurrentStatus()
        {
            ((PlayerStatus)currentPlayer).setManager();
        }
        public void setMultiplayer(bool isMultiplayer)
        {
            this.isMultiplayer = isMultiplayer;
        }
        public bool checkLiveStatus(int num)
        {
            DLink temp = pActive;
            if (isMultiplayer)
            {
                while (temp != null)
                {
                    if (((PlayerStatus)temp).getLives() > num)
                    {
                        return true;
                    }
                    temp = temp.pNext;
                }
                return false;
            }
            else
            {
                if (((PlayerStatus)temp).getLives() > num)
                {
                    return true;
                }
                return false;
            }
        }
        public bool checkMultiplayer()
        {
            return isMultiplayer;
        }
        public void removeLive()
        {
            ((PlayerStatus)currentPlayer).setLives(((PlayerStatus)currentPlayer).getLives() - 1);
        }
        public void setAllLives(int live)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                ((PlayerStatus)temp).setLives(live);
                temp = temp.pNext;
            }
        }
        public int getCurrentPlayer()
        {
            return ((PlayerStatus)currentPlayer).getPlayerNum();
        }
    }
}
