using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class ImageManager : Manager
    {
        
        
        public ImageManager(int InitialNumReserved, SpriteType name)
            : base(InitialNumReserved)
        {


            this.spriteName = name;
            
            this.pActive = null;
            

            // Preload the reserve
            //this.privFillReservedPool(InitialNumReserved);
        }
        public int getTotalImages()
        {
            return this.active;
        }
        public void createActive(Image image, int val)
        {
            DLink pLink = new ImageDataNode(image, name, val);
            AddToActive(pLink);
            /*if (this.pActive == null)
            {
                this.pActive = pLink;
            }
            else
            {
                DLink pHeadTemp = this.pActive;
                while (pHeadTemp.pNext != null)
                {
                    pHeadTemp = pHeadTemp.pNext;
                }
                pHeadTemp.pNext = pLink;
            }*/
            /*DLink pLink;
            
            DLink pActiveTemp = this.pActive;
            // Are there any nodes on the Reserve list?

            pLink = new ImageDataNode(image, name, val);

            this.active++;


            // Zero DLink
            pLink.Clear();

            // Fill data
            ImageDataNode pNode = (ImageDataNode)pLink;
            
            pNode.setImage(image);

            DLink.AddToFront(ref pActiveTemp, pNode);
            pActive = pNode;*/
            
        }


        public SpriteType name
        {
            get
            {
                return this.spriteName;
            }
            set
            {
                if (spriteName != SpriteType.Unitialized)
                {
                    this.spriteName = value;
                }
            }
        }
        
        /*protected  ImageLink CreateNode()
        {
            DLink pNode = new ImageDataNode(ImageFactoryCrab.Image_Factory_Crab().createImage(0),SpriteType.Unitialized,0);
            return pNode;
        }*/

        public Image findImage(int name)
        {
            return Find(name).getImage();
        }

        public ImageDataNode Find(int name)
        {
            // search the active list
            DLink pNode = this.pActive;
            ImageDataNode pData = null;

            while (pNode != null)
            {
                pData = (ImageDataNode)pNode;
                if (pData.getNum() == name)
                {
                    // found it
                    break;
                }
                pNode = (DLink)pNode.pNext;
            }
            return pData;
        }

        
    }
}
