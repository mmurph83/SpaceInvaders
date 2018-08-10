using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ScoreFactory
    {
        static ScoreFactory factory = new ScoreFactory();
        ScoreController player1score = new ScoreController();
        ScoreController player2score = new ScoreController();
        ScoreController highscore = new ScoreController();
        public static ScoreFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public ScoreController getPlayerScore(int playerNum)
        {
            switch (playerNum)
            {
                case 1:
                    return player_1;
                default:
                    return player_2;
            }
        }
        public ScoreController player_1
        {
            get
            {
                return player1score;
            }
        }
        public ScoreController player_2
        {
            get
            {
                return player2score;
            }
        }
        public ScoreController high_score
        {
            get
            {
                return highscore;
            }
        }
    }
}
