using System;

namespace Project 
{
    class Diamond : Block
    {
        public Diamond(): base()
        {
            blockType = "Diamond";
        }
        public Diamond(int newCount): base(newCount)
        {
            blockType = "Diamond";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond has been used");
        }

    }
}