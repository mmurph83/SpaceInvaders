using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayGameState : GameState
    {
        AnimationManager m;

        MovementController movement;
        //CollisionSprite collisionTest;
        Command resetCommand;
        bool isResetting = false;
        Sprite explosion;
        Player player;
        PlayerInputController inputController;

        GridWallCollisionList wallList;

        ProjectileController projectileController;
        ShieldList shieldList;
        
        //CollisionController test;
        CollisionIterator it;
        CommandProjectileSpawnController controller;

        ScoreController score;
        UFOSpawnController ufoController;
        private bool loading = false;
        private bool start = false;
        public override void Load()
        {
            Receiver.instance.clearTime();
            if (isLoaded == false)
            {
                resetCommand = new PlayGameResetCommand();
                explosion = RealSpriteFactory.getSprite(SpriteType.Explosion);
                CollisionSubjectFactory.getFactory.getAlienVictorySubject().setPos(800, 100);
                CollisionSubjectFactory.getFactory.getAlienVictorySubject().setScale(100, 30);
                ufoController = UFOSpawnControllerFactory.getFactory.getController;
                isLoaded = true;
                it = CollisionControllerFactory.getFactor.getIterator;

                shieldList = ShieldListFactory.getFactory.getShieldList();
                //collisionBox = new Azul.SpriteBox(new Azul.Rect(1,1,1,1), new Azul.Color(1.0f, 1.0f, 1.0f, 1.0f));
                Azul.Texture f = new Azul.Texture("Font.tga");

                GameObjectTreeFactory.getFactory.getUfo().setPos(100,100);
                GameObjectTreeFactory.getFactory.getUfo().setStatus(Status.Active);

                m = AnimationManagerList.instance.findManager(SpriteType.Crab);
                //letterManager = LetterManagerFactory.getFactory().createManager("HELLO BOYS");
                //letterManager.setPos(100, 100);

                //---------------------------------------------------------------------------------------------------------
                // Load the Textures
                //---------------------------------------------------------------------------------------------------------


                movement = MovementControllerFactory.getFactory.getController();
                
                /*colObserver = new MovementCollisionObserver(movement);
                colSubject = new AlienGridCollisionSubject(GameObjectTreeFactory.getFactory.alien, SpriteType.Unitialized);
                colSubject.addObserver(new MovementCollisionObserver(movement));*/
                //colSubject = CollisionSubjectFactory.getFactory.getAlienSubject();
                //colSubject.addCollisionTest(collisionTest);
                wallList = GridWallCollisionListFactory.getFactory().getList();
                player = PlayerFactory.instance.getPlayer();
                
                //player.setSpriteScale(100, 100);
                inputController = PlayerInputControllerFactory.getFactory.getController();



                projectileController = ProjectileControllerFactory.instance.controller;
                controller = CommandProjectileFactory.getFactory.controller;
                score = ScoreFactory.getFactory.player_1;
                //score.setPos(100, 100);
                //ScoreFactory.getFactory.player_2.setPos(400,100);
                //ScoreFactory.getFactory.high_score.setPos(300, 900);
                score.addScore(0);
                score.setImages();
                explosion.setPosition(300, 100);
            }
            if (start == false)
            {
                movement.setMovementDirection(MovementStateFactory.right);
                PlayerStatusControllerFactory.getFactory.getController.setAllPos(100, 600);
                PlayerStatusControllerFactory.getFactory.getController.setAllLives(3);
                ScoreFactory.getFactory.player_1.setScore(0);
                ScoreFactory.getFactory.player_2.setScore(0);
                ScoreFactory.getFactory.player_1.setImages();
                PlayScoreControllerFactory.getFactory.playController.setPlayerScoreController(ScoreFactory.getFactory.player_1);
                ScoreFactory.getFactory.player_2.setImages();
                //ufoController.getUfo().setStatus(Status);
                start = true;
            }
            CollisionSpawnFactory.getFactory.setAllInactive();
            setAllActive();
            resetPosition();
            addToRecevier();
            /*ufoController.addToReceiver();
            movement.addCommandToReceiver();
            
            Scale sh = SizeFactory.getFactory.shieldScale;
            GameObjectTreeFactory.getFactory.alien.setPos(100, 600, SizeFactory.getFactory.alienScale.spriteWidth, SizeFactory.getFactory.alienScale.spriteHeight);
            movement.setActive(Status.Active);
            movement.setAllActive(Status.Active);
            shieldList.setAllActive(Status.Active);
            shieldList.setPos(100, 200, sh.colWidth, sh.colHeight, 0);
            shieldList.setPos(300, 200, sh.colWidth, sh.colHeight, 1);
            shieldList.setPos(500, 200, sh.colWidth, sh.colHeight, 2);
            shieldList.setPos(700, 200, sh.colWidth, sh.colHeight, 3);
            player.setPos(100, 100);
            controller.addToReceiver();
            player.setStatus(Status.Active);*/
            projectileController.deactiateProjectiles();
        }
        public override void Update()
        {
            
            if (movement.getStatus() == Status.Inactive)
            {
                loading = false;
                Load();
            }
            if (loading)
            {
                it.checkCollision();
            }
            else
            {
                loading = true;
            }
            ufoController.Update();
            if (player.getStatus() == Status.Inactive)
            {
                if (isResetting == false)
                {
                    isResetting = true;
                    Receiver.instance.clearTime();
                    Receiver.instance.addCommand(resetCommand);
                }
            }
            //playerHit();
        }
        public override void Render()
        {
            
            TimerManager.instance.updateTime();
            Receiver.instance.execute();

            PlayerInputControllerFactory.getFactory.getController().checkInput();
            PlayerInputControllerFactory.getFactory.getController().translate();
            

            
            SpriteBatchFactory.instance.render();

            projectileController.updateProjectiles();
            
           
            if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_0))
            {
                shieldList.setAllActive(Status.Active);
                movement.setAllActive(Status.Active);
                
            }
            else if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_9))
            {
                GameControllerFactory.getFactory.c.setState(GameMode.Start);
            }
            else if (Azul.Input.GetKeyState(Azul.AZUL_KEY.KEY_3))
            {
                CollisionSpriteManagerFactory.instance.getManager().setRender();
            }
            
        }
        void setAllActive()
        {
            movement.setActive(Status.Active);
            movement.setAllActive(Status.Active);
            shieldList.setAllActive(Status.Active);
            player.setStatus(Status.Active);
        }
        void resetPosition()
        {
            Scale sh = SizeFactory.getFactory.shieldScale;
            GameObjectTreeFactory.getFactory.alien.setPos(100, 600, SizeFactory.getFactory.alienScale.spriteWidth, SizeFactory.getFactory.alienScale.spriteHeight);
            shieldList.setPos(100, 200, sh.colWidth, sh.colHeight, 0);
            shieldList.setPos(300, 200, sh.colWidth, sh.colHeight, 1);
            shieldList.setPos(500, 200, sh.colWidth, sh.colHeight, 2);
            shieldList.setPos(700, 200, sh.colWidth, sh.colHeight, 3);
            player.setPos(100, 100);
            ufoController.setPos(-100, -100);
        }
        void addToRecevier()
        {
            ufoController.addToReceiver();
            movement.addCommandToReceiver();
            controller.addToReceiver();
        }
        public void playerHit()
        {
            if (player.getStatus() != Status.Active)
            {
                CollisionSpawnFactory.getFactory.setAllInactive();
                projectileController.deactiateProjectiles();
                PlayerStatusControllerFactory.getFactory.getController.setCurrentY(GameObjectTreeFactory.getFactory.alien.getLowestHeight());
                PlayerStatusControllerFactory.getFactory.getController.checkCurrentStatus();
                PlayerStatusControllerFactory.getFactory.getController.setToNextPlayer();
                PlayerStatusControllerFactory.getFactory.getController.setCurrentStatus();
                PlayerStatusControllerFactory.getFactory.getController.removeLive();
                if (PlayerStatusControllerFactory.getFactory.getController.checkMultiplayer())
                {
                    GameObjectTreeFactory.getFactory.alien.setPos(PlayerStatusControllerFactory.getFactory.getController.getCurrentX(), PlayerStatusControllerFactory.getFactory.getController.getCurrentY(), SizeFactory.getFactory.alienScale.spriteWidth, SizeFactory.getFactory.alienScale.spriteHeight);
                }
                PlayScoreControllerFactory.getFactory.playController.setPlayerScoreController(ScoreFactory.getFactory.getPlayerScore(PlayerStatusControllerFactory.getFactory.getController.getCurrentPlayer()));
                if (PlayerStatusControllerFactory.getFactory.getController.checkLiveStatus(0))
                {
                    player.setStatus(Status.Active);
                    addToRecevier();
                }
                else
                {
                    GameControllerFactory.getFactory.c.setState(GameMode.Start);
                }
            }
        }
        public override void reset()
        {
            isResetting = false;
            playerHit();
        }
        public override void UnLoad()
        {
            start = false;
            CollisionSpawnFactory.getFactory.setAllInactive();
            movement.setActive(Status.Inactive);
            movement.setAllActive(Status.Inactive);
            projectileController.deactiateProjectiles();
            player.setStatus(Status.Inactive);
            shieldList.setAllActive(Status.Inactive);
            loading = false;
            Scale sh = SizeFactory.getFactory.shieldScale;
            GameObjectTreeFactory.getFactory.alien.setPos(100, -2600, SizeFactory.getFactory.alienScale.spriteWidth, SizeFactory.getFactory.alienScale.spriteHeight);
            shieldList.setPos(100, -2000, sh.colWidth, sh.colHeight, 0);
            shieldList.setPos(300, -2000, sh.colWidth, sh.colHeight, 1);
            shieldList.setPos(500, -2200, sh.colWidth, sh.colHeight, 2);
            shieldList.setPos(700, -2200, sh.colWidth, sh.colHeight, 3);
            ufoController.setPos(-200, -200);
            player.setPos(100, -2100);
        }
    }
}
