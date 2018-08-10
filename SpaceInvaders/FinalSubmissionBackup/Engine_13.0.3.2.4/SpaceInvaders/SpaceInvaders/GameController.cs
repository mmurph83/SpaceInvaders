using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameController
    {
        StartGameState start;
        PlayGameState play;
        GameState currentState;
        public GameController()
        {
            start = GameStateFactory.getFactory.s;
            play = GameStateFactory.getFactory.p;
            currentState = start;
        }
        public void Update()
        {
            currentState.Update();
        }
        public void Render()
        {
            currentState.Render();
        }
        public void reset()
        {
            currentState.reset();
        }
        public void setState(GameMode mode)
        {
            currentState.UnLoad();
            switch (mode)
            {
                case GameMode.Start:
                    this.currentState = start;
                    break;
                case GameMode.Play:
                    this.currentState = play;
                    break;
                case GameMode.Over:
                    break;
                default:
                    break;
            }
            this.currentState.Load();
        }
    }
    public enum GameMode { Play,Start,Over}
}
