using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameStateFactory
    {
        StartGameState start;
        PlayGameState play;
        static GameStateFactory factory = new GameStateFactory();
        public GameStateFactory()
        {
            start = new StartGameState();
            play = new PlayGameState();
        }
        public static GameStateFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public StartGameState s
        {
            get { return start; }
        }
        public PlayGameState p
        {
            get { return play; }
        }
    }
}
