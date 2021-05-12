using System;

namespace Project
{
    class GoldOreBlock : Block, Meltable
    {
        public GoldOreBlock(): base()
        {
            blockType = "GoldOre Block";
        }
        
        public GoldOreBlock(int newCount) : base(newCount)
        {
            blockType = "GoldOre block";
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