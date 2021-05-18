using System;

namespace Project
{
    class CobblestoneBlock : Block, Meltable
    {
        public CobblestoneBlock(): base()
        {
            blockType = "Cobblestone Block";
        }
        
        public CobblestoneBlock(int newCount) : base(newCount)
        {
            blockType = "Cobblestone block";
            classType = this;
            image = "img/CobblestoneBlock";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Cobblestone has been placed");
        }

        public Block Melt()
        {
            Count--;
            Console.WriteLine("Cobblestone melts into stone");
            return new StoneBlock(1);

        }
    }
}