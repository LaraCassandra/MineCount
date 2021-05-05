using System;

namespace Project
{
    class SandBlock : Block
    {
        public SandBlock(int newCount) : base(newCount)
        {
            blockType = "Sand block";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Sand has been placed");
        }
    }
}