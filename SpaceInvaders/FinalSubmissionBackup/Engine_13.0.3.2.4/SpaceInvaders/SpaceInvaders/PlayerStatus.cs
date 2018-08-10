using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerStatus : DLink
    {
        int score = 0;
        int lives = 0;
        int playerNum = 0;
        float x = 100;
        float y = 600;
        MovementState state = MovementStateFactory.left;
        PlayerModeStatusManager manager;
        public PlayerStatus(int playerNum)
        {
            this.playerNum = playerNum;
            this.manager = PlayerModeStatusManagerFactory.getFactory.getPlayModeStatusManager(playerNum);
        }
        public void setScore(int score)
        {
            this.score = score;
        }
        public void setLives(int lives)
        {
            this.lives = lives;
        }
        public int getLives()
        {
            return lives;
        }
        public int getScore()
        {
            return score;
        }
        public int getPlayerNum()
        {
            return playerNum;
        }
        public void setPlayerNumber(int num)
        {
            this.playerNum = num;
        }
        public void checkManager()
        {
            manager.checkStatus();
        }
        public void setManager()
        {
            manager.setStatus();
        }
        public float getX()
        {
            return x;
        }
        public float getY()
        {
            return y;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
    }
}
