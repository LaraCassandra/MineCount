using System;

namespace Project 
{
    class GlassBlock : Block
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

    }
}