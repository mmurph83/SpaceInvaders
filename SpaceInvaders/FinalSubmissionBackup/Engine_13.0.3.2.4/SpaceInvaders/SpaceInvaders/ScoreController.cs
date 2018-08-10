using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ScoreController
    {
        LetterManager scoreManager;
        int score = 0;
        public ScoreController()
        {
            scoreManager = LetterManagerFactory.getFactory().createManager("000000");
        }
        public void addScore(int i)
        {
            score = score + i;
        }
        public int getScore()
        {
            return score;
        }
        public void setScore(int i)
        {
            score = i;
        }
        public void setImages()
        {
            
            scoreManager.setImageReverse(score.ToString());
        }
        public void setPos(float x, float y)
        {
            this.scoreManager.setPos(x,y);
        }
    }
}
