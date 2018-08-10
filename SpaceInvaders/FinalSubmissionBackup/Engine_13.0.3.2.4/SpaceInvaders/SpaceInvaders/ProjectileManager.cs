using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ProjectileManager : Manager
    {
        float xOffset = 1;
        float yOffset = 1;
        public void updatePos()
        {
            DLink temp = pActive;
            while (temp != null)
            {
                if (((ProjectileDataNode)temp).getProjectile().getStatus() == Status.Active)
                {
                    ((ProjectileDataNode)temp).translate(xOffset, yOffset);
                    temp = temp.pNext;
                }
                /*else
                {
                    DLink reserveTemp = temp;
                    temp = temp.pNext;
                    
                    if (active == 1)
                    {
                        pActive = null;
                        
                    
                    }
                    else
                    {
                        if (((ProjectileDataNode)pActive).getProjectile().getStatus() != Status.Active)
                        {
                            pActive = pActive.pNext;
                            pActive.pPrev = null;
                            temp.pNext = null;
                        }
                        else
                        {
                            if (reserveTemp.pNext != null)
                            {

                                reserveTemp.pNext.pPrev = reserveTemp.pPrev;
                                
                            }
                            reserveTemp.pPrev.pNext = reserveTemp.pNext;
                            reserveTemp.pNext = null;
                            reserveTemp.pPrev = null;
                            
                        }
                        
                    }
                    AddToReserve(reserveTemp);
                    active--;
                }*/
                else
                {
                    DLink reserveTemp = temp;
                    temp = temp.pNext;

                    if (active == 1)
                    {
                        pActive = null;


                    }
                    else
                    {
                        if (reserveTemp.pPrev != null)
                        {
                            reserveTemp.pPrev.pNext = reserveTemp.pNext;
                        }
                        else
                        {
                            pActive = pActive.pNext;
                        }
                        if (reserveTemp.pNext != null)
                        {
                            reserveTemp.pNext.pPrev = reserveTemp.pPrev;
                        }

                    }
                    AddToReserve(reserveTemp);
                    active--;
                }
            }
        }
        public void addProjectile(Projectile projectile)
        {
            this.AddToActive(new ProjectileDataNode(projectile));
        }
        public Projectile addProjectileToActive()
        {
            DLink temp = pReserve;
            reserve--;
            if (reserve == 0)
            {
                pReserve = null;
            }
            else
            {
                pReserve = pReserve.pNext;
                pReserve.pPrev = null;
                temp.pNext = null;
            }
            AddToActive(temp);
            return ((ProjectileDataNode)pActive).getProjectile();
        }
        public void assignAllToReserve()
        {
            if (pActive != null)
            {
                DLink temp = pActive;
                while (pActive.pNext != null)
                {
                    ((ProjectileDataNode)temp).getProjectile().setStatus(Status.Inactive);
                    pActive = pActive.pNext;
                    temp.pNext = null;
                    pActive.pPrev = null;
                    active--;
                    AddToReserve(temp);
                    temp = pActive;
                }
                pActive = null;
                ((ProjectileDataNode)temp).getProjectile().setStatus(Status.Inactive);
                active--;
                AddToReserve(temp);
            }
        }
        public void sendProjectiles(GameObjectTree gameTree)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                if (((ProjectileDataNode)temp).getProjectile().getStatus() == Status.Active)
                {
                    gameTree.checkProjectileCollision(((ProjectileDataNode)temp).getProjectile());
                }
                temp = temp.pNext;
            }
        }
        public void checkWallCollision(GridWallCollisionList g)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                if (((ProjectileDataNode)temp).getProjectile().getStatus() == Status.Active)
                {
                    if(g.checkCollision(((ProjectileDataNode)temp).getProjectile().getCollisionComponent())){
                        ((ProjectileDataNode)temp).getProjectile().notifyHit();
                    }
                }
                temp = temp.pNext;
            }
        }
        public void checkUFOCollision(Alien alien)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                if (((ProjectileDataNode)temp).getProjectile().getStatus() == Status.Active)
                {
                    if (alien.getCollisionComponent().checkCollision(alien.getCollisionComponent(), ((ProjectileDataNode)temp).getProjectile().getCollisionComponent()))
                    {
                        ((ProjectileDataNode)temp).getProjectile().notifyHit();
                        alien.notifyHit();
                    }
                }
                temp = temp.pNext;
            }
        }
        public void checkPlayerCollision(Player player)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                if (((ProjectileDataNode)temp).getProjectile().getStatus() == Status.Active)
                {
                    if (player.getCollisionComponent().checkCollision(player.getCollisionComponent(), ((ProjectileDataNode)temp).getProjectile().getCollisionComponent()))
                    {
                        ((ProjectileDataNode)temp).getProjectile().notifyHit();
                        player.notifyHit();
                    }
                }
                temp = temp.pNext;
            }
        }
        public void checkProjectileCollision(Projectile projectile)
        {
            DLink temp = pActive;
            if (projectile.getStatus() == Status.Active)
            {
                while (temp != null)
                {
                    if (((ProjectileDataNode)temp).getProjectile().getCollisionComponent().checkCollision(((ProjectileDataNode)temp).getProjectile().getCollisionComponent(), projectile.getCollisionComponent()))
                    {
                        projectile.notifyHit();
                        ((ProjectileDataNode)temp).getProjectile().notifyHit();
                        temp = null;
                    }
                    else
                    {
                        temp = temp.pNext;
                    }
                }
            }
        }
        public void checkProjectileManagerCollision(ProjectileManager manager)
        {
            DLink temp = pActive;
            while (temp != null)
            {
                manager.checkProjectileCollision(((ProjectileDataNode)temp).getProjectile());
                temp = temp.pNext;
            }
        }
        public void setSpeed(float x, float y)
        {
            this.xOffset = x;
            this.yOffset = y;
        }
    }
}
