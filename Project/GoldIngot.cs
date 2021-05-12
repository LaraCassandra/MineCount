using System;

namespace Project 
{
    class GoldIngot : Block
    {
        public GoldIngot(): base()
        {
            blockType = "Gold Ingot";
        }
        public GoldIngot(int newCount): base(newCount)
        {
            blockType = "Iron Ingot";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold has been used");
        }

    }
}