using System;

namespace Project
{
    class StoneBlock : Block
    {
        public StoneBlock(int newCount) : base(newCount)
        {
            blockType = "Stone block";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone has been placed");
        }
    }
}