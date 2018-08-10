using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class StartGameState :GameState
    {
        LetterManagerList list;
        public StartGameState()
        {
            LetterManager manager = LetterManagerFactory.getFactory().createManager("SCORE<1>   HI-SCORE   SCORE<2>");
            manager.setPos(80, 950);
            /*manager = LetterManagerFactory.getFactory().createManager("HI-SCORE");
            manager.setPos(350, 950);
            manager = LetterManagerFactory.getFactory().createManager("SCORE<2>");
            manager.setPos(600, 950);*/
            list = new LetterManagerList();
            ScoreFactory.getFactory.player_1.setPos(100, 900);
            ScoreFactory.getFactory.player_2.setPos(650, 900);
            ScoreFactory.getFactory.high_score.setPos(380, 900);
        }
        public override void Load()
        {
            LetterManagerFactory.getFactory();
            /*ScoreFactory.getFactory.player_1.setPos(100, 100);
            ScoreFactory.getFactory.player_2.setPos(400, 100);
            ScoreFactory.getFactory.high_score.setPos(300, 900);*/
        }
        public override void Update()
        {
            if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_1))
            {
                GameControllerFactory.getFactory.c.setState(GameMode.Play);
                PlayerStatusControllerFactory.getFactory.getController.setMultiplayer(false);
            }
            else if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_2))
            {
                GameControllerFactory.getFactory.c.setState(GameMode.Play);
                PlayerStatusControllerFactory.getFactory.getController.setMultiplayer(true);
            }
        }
        public override void Render()
        {
            SpriteBatchFactory.instance.render();
        }
        public override void UnLoad()
        {
            
        }
    }
}
