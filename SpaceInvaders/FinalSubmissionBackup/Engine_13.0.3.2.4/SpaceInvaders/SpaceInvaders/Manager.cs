

namespace SpaceInvaders
{
    public abstract class Manager
    {

        protected SpriteType spriteName;
        protected int active = 0;
        protected int reserve = 0;
        protected DLink pActive;
        protected DLink pReserve;
        
        public Manager(int InitialNumReserved): base()
        {
            

            
            
            

            // Preload the reserve
            //this.privFillReservedPool(InitialNumReserved);
        }
        public Manager()
            : base()
        {






           
        }
        public float getTotalActive()
        {
            return active;
        }
        public float getTotalReserve()
        {
            return reserve;
        }
        protected virtual void AddToActive(DLink newActive)
        {
            this.active++;
            if (this.pActive == null)
            {
                this.pActive = newActive;
                newActive.pNext = null;
                newActive.pPrev = null;
            }
            else
            {
                AddToHead(ref this.pActive, newActive);
            }
        }
        protected void AddToReserve(DLink newReserve)
        {
            this.reserve++;
            if (this.pReserve == null)
            {
                this.pReserve = newReserve;
                newReserve.pNext = null;
                newReserve.pPrev = null;
            }
            else
            {
                AddToHead(ref this.pReserve, newReserve);
            }
        }
        protected void AddToHead(ref DLink head, DLink node)
        {
            node.pNext = head;
            head.pPrev = node;
            node.pPrev = null;
            head = node;
        }
        public SpriteType getName()
        {
            return this.spriteName;
        }
       
    }
    
}
