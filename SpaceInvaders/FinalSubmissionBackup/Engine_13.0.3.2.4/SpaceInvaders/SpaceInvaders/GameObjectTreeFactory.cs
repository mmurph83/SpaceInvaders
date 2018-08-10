using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameObjectTreeFactory
    {
        public GameObjectTree alien;
        static GameObjectTreeFactory factory = new GameObjectTreeFactory();
        Alien ufo;
        public GameObjectTreeFactory()
        {
            alien = makeGameObjectTree();

            SpriteManager m = SpriteManagerFactory.createSpriteManager(SpriteType.Alien, 0);
            GameObject temp = GameObjectFactory.createGameObject();
            Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.UFO);
            Scale a = SizeFactory.getFactory.alienScale;
            m.createActive(s);
            temp.setSprite(s);
            temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
            temp.setScale(a.spriteWidth, a.spriteHeight);
            temp.setColScale(a.colWidth, a.colHeight);
            ufo = new Alien(temp, 0);
            ufo.setStatus(Status.Inactive);
        }
        public static GameObjectTreeFactory getFactory
        {
            get
            {
                return factory;
            }
        }
        public GameObjectTree getAlien()
        {
            return alien;
        }
        GameObjectTree makeGameObjectTree()
        {
            SpriteManager m = SpriteManagerFactory.createSpriteManager(SpriteType.Alien,0);
            GameObjectTree g = new GameObjectTree();
            Scale a = SizeFactory.getFactory.alienScale;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Crab);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Alien t = new Alien(temp,ScoreReferenceFactory.getFactory.getScore(SpriteType.Crab));
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, i, t);
                }
            }
            for (int i = 2; i < 4; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Bug);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Alien t = new Alien(temp, ScoreReferenceFactory.getFactory.getScore(SpriteType.Bug));
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, i, t);
                }
            }
            for (int i = 4; i < 5; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Squid);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Alien t = new Alien(temp, ScoreReferenceFactory.getFactory.getScore(SpriteType.Squid));
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, i, t);
                }
            }
            return g;
        }
        public GameObjectTree makeGameObjectTreeShield()
        {
            SpriteManager m = SpriteManagerFactory.createSpriteManager(SpriteType.Shield, 0);
            GameObjectTree g = new GameObjectTree();
            Scale a = SizeFactory.getFactory.shieldScale;
            for (int i = 3; i < 11; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Shield);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Shield t = new Shield(temp);
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, i, t);
                }
            }
            
                for (int j = 0; j < 3; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Shield);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Shield t = new Shield(temp);
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, 2, t);
                }
                for (int j = 5; j < 8; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Shield);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Shield t = new Shield(temp);
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, 2, t);
                }
           
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Shield);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Shield t = new Shield(temp);
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, i, t);
                }
                for (int j = 6; j < 8; j++)
                {
                    GameObject temp = GameObjectFactory.createGameObject();
                    Sprite s = ProxySpriteFactory.makeProxySprite(SpriteType.Shield);
                    m.createActive(s);
                    temp.setSprite(s);
                    temp.setCollisionSprite(ProxySpriteCollisionFactory.proxy);
                    temp.setScale(a.spriteWidth, a.spriteHeight);
                    temp.setColScale(a.colWidth, a.colHeight);
                    Shield t = new Shield(temp);
                    PlayerModeStatusManagerFactory.getFactory.addObject(t);
                    g.AddToActive(j, i, t);
                }
            }
            return g;
        }
        public Alien getUfo()
        {
            return ufo;
        }
    }
}
