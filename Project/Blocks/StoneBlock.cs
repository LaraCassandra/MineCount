using System;

namespace Project
{
    class StoneBlock : Block
    {
        public StoneBlock(int newCount) : base(newCount)
        {
            blockType = "StoneBlock";
            classType = this;
            image = "img/StoneBlock.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone has been placed");
        }
    }
}