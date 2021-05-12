using System;

namespace Project
{
    class SandBlock : Block, Meltable
    {
        public SandBlock(): base()
        {
            blockType = "Sand Block";
        }
        
        public SandBlock(int newCount) : base(newCount)
        {
            blockType = "Sand block";
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