using System;

namespace Project 
{
    class GoldIngot : Block
    {
        public GoldIngot(): base()
        {
            blockType = "Gold Ingot";
            classType = this;
            image = "img/GoldIngot.png";
        }
        public GoldIngot(int newCount): base(newCount)
        {
            blockType = "Gold Ingot";
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