using System;

namespace Project
{
    class IronOreBlock : Block, Meltable
    {
        public IronOreBlock(): base()
        {
            blockType = "IronOre Block";
            classType = this;
            image = "img/IronOreBlock.png";
        }
        
        public IronOreBlock(int newCount) : base(newCount)
        {
            blockType = "IronOre block";
            classType = this;
            image = "img/IronOreBlock.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("IronOre has been placed");
        }

        public Block Melt()
        {
            Count--;
            Console.WriteLine("IronOre melts into iron ingot");
            return new IronIngot(1);

        }
    }
}