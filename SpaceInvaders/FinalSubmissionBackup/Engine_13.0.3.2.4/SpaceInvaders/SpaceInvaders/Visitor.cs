using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public abstract class Visitor
    {
        public virtual bool visitGrid(CollisionSprite visitor)
        {
            return false;
        }
        public virtual ObjectController visitObject(CollisionSprite visitor)
        {
            return null;
        }
        public virtual void visit(GridWallCollisionList grid)
        {

        }
        public virtual void visit(GameObjectTree tree)
        {

        }
        public virtual void visit(MovementController movement) { }
        public virtual void visit(ShieldCollisionController c) { }
        public virtual void visit(PlayerCollisionController c) { }
        public virtual void visit(ProjectileCollisionController c) { }
        public virtual void visit(WallCollisionController c) { }
        public virtual void visit(AlienCollisionController c) { }
        public virtual void visit(CollisionController c) { }
        
    }
}
