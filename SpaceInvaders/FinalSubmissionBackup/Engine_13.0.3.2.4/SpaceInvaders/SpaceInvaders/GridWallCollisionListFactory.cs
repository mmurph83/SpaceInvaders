using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GridWallCollisionListFactory
    {
        static GridWallCollisionListFactory factory = new GridWallCollisionListFactory();
        GridWallCollisionList wallList;
        GridWallCollisionListFactory(){
            wallList = new GridWallCollisionList();
            ProxyCollisionSprite collisionTest = ProxySpriteCollisionFactory.proxy;
            collisionTest.setTransformation(900, 500, 100, 1000);
                wallList.addCollisionTest(collisionTest);
                collisionTest = ProxySpriteCollisionFactory.proxy;
                collisionTest.setTransformation(0, 500, 100, 1000);
                wallList.addCollisionTest(collisionTest);

                collisionTest = ProxySpriteCollisionFactory.proxy;
                collisionTest.setTransformation(500, 1000, 1000, 100);
                wallList.addCollisionTest(collisionTest);
                collisionTest = ProxySpriteCollisionFactory.proxy;
                collisionTest.setTransformation(400, 0, 1000, 100);
                wallList.addCollisionTest(collisionTest);
        }
        public static GridWallCollisionListFactory getFactory()
        {
            return factory;
        }
        public GridWallCollisionList getList()
        {
            return wallList;
        }
    }
}
