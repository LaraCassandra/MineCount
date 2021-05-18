using System;

namespace Project
{

    class WoodBlock: Block, Flammable, Meltable
    {
        public WoodBlock(): base()
        {
            blockType = "Wood Block";
            classType = this;
            image = "img/WoodBlock.png";
        }
        public WoodBlock(int newCount) :base(newCount)
        {
            blockType = "Wood block";
            classType = this;
            image = "img/WoodBlock.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood block has been placed");
        }

        public void Burn()
        {
            Count--;
            Console.WriteLine("Wood is burning");
        }

        public Block Melt()
        {
            Count--;
            Console.WriteLine("Wood metls into coal");
            return new Coal(1);
        }
    }
}