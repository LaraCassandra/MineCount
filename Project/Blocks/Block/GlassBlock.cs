using System;

namespace Project 
{
    class GlassBlock : Block
    {
        public GlassBlock(): base()
        {
            blockType = "Glass Block";
            classType = this;
            image = "img/GlassBlock.png";
        }
        public GlassBlock(int newCount): base(newCount)
        {
            blockType = "Glass block";
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