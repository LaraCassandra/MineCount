using System;

namespace Project 
{
    class GlassBlock : Block
    {
        public GlassBlock(int newCount): base(newCount)
        {
            blockType = "GlassBlock";
            classType = this;
            image = "img/GlassBlock.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Glass block has been placed");
        }

    }
}