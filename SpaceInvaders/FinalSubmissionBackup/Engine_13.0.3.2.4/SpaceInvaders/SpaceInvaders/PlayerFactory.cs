using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class PlayerFactory
    {
        Player player;

        static PlayerFactory playerFactory = new PlayerFactory();
        public PlayerFactory()
        {
            GameObject tempGame = new GameObject();
            
            Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Player);
            tempGame.setSprite(s);
            tempGame.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
            tempGame.setColScale(SizeFactory.getFactory.playerScale.colWidth, SizeFactory.getFactory.playerScale.colHeight);
            SpriteManager tempSpriteManager = SpriteManagerFactory.createSpriteManager(SpriteType.Player, 0);
            Scale te = SizeFactory.getFactory.playerScale;
            tempGame.setColScale(te.colWidth, te.colHeight);
            tempGame.setScale(te.spriteWidth, te.spriteHeight);
            tempSpriteManager.createActive(s);
            
            player = new Player(tempGame);
            this.player.setSpriteScale(100, 100);
        }
        public static PlayerFactory instance
        {
            get
            {
                return playerFactory;
            }
        }
        public Player getPlayer()
        {
            return player;
        }
    }
}
