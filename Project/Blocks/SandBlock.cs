using System;

namespace Project
{
    class SandBlock : Block, Meltable
    {
        public SandBlock(int newCount) : base(newCount)
        {
            blockType = "SandBlock";
            classType = this;
            image = "img/SandBlock.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Sand has been placed");
        }

        public Block Melt()
        {
            Count--;
            Console.WriteLine("Sand melts into glass");
            return new SandBlock(1);

        }
    }
}