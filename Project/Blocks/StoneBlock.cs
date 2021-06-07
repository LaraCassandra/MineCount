using System;

namespace Project
{
    class StoneBlock : Block
    {
        public StoneBlock(): base()
        {
            blockType = "Stone Block";
            classType = this;
            image = "img/StoneBlock.png";
        }
        public StoneBlock(int newCount) : base(newCount)
        {
            blockType = "Stone block";
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