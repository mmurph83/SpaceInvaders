using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayScoreController
    {
        ScoreController currentController;
        ScoreController highScoreController;
        public PlayScoreController()
        {
            currentController = ScoreFactory.getFactory.player_1;
            highScoreController = ScoreFactory.getFactory.high_score;
        }
        public void addScore(int i)
        {
            currentController.addScore(i);
            if (currentController.getScore() > highScoreController.getScore())
            {
                highScoreController.setScore(currentController.getScore());
                highScoreController.setImages();
            }
            currentController.setImages();
        }
        public void setPlayerScoreController(ScoreController controller)
        {
            this.currentController = controller;
        }
    }
}
