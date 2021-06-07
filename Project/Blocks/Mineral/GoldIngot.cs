using System;

namespace Project 
{
    class GoldIngot : Block
    {
        public GoldIngot(int newCount): base(newCount)
        {
            blockType = "GoldIngot";
            classType = this;
            image = "img/GoldIngot.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold has been used");
        }

    }
}