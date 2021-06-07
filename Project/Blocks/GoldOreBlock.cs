using System;

namespace Project
{
    class GoldOreBlock : Block, Meltable
    {       
        public GoldOreBlock(int newCount) : base(newCount)
        {
            blockType = "GoldOreBlock";
            classType = this;
            image = "img/GoldOreBlock.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("GoldOre has been placed");
        }

        public Block Melt()
        {
            Count--;
            Console.WriteLine("GoldOre melts into gold ingot");
            return new GoldIngot(1);

        }
    }
}