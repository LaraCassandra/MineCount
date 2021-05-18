using System;

namespace Project 
{
    class Diamond : Block
    {
        public Diamond(): base()
        {
            blockType = "Diamond";
            classType = this;
            image = "img/Diamond.png";
        }
        public Diamond(int newCount): base(newCount)
        {
            blockType = "Diamond";
            classType = this;
            image = "img/Diamond.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond has been used");
        }

    }
}