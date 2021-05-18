using System;

namespace Project
{
    class SandBlock : Block, Meltable
    {
        public SandBlock(): base()
        {
            blockType = "Sand Block";
            classType = this;
            image = "img/SandBlock.png";
        }
        
        public SandBlock(int newCount) : base(newCount)
        {
            blockType = "Sand block";
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