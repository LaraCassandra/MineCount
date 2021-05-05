using System;

namespace Project 
{
    class GlassBlock : Block, Meltable
    {
        public GlassBlock(): base()
        {
            blockType = "Glass Block";
        }
        public GlassBlock(int newCount): base(newCount)
        {
            blockType = "Glass block";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Glass block has been placed");
        }

        public Block Melt()
        {
            Count--;
            Console.WriteLine("Sand melts into glass");
            return new SandBlock(1);

        }

    }
}