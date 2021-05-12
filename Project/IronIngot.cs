using System;

namespace Project 
{
    class IronIngot : Block
    {
        public IronIngot(): base()
        {
            blockType = "Iron Ingot";
        }
        public IronIngot(int newCount): base(newCount)
        {
            blockType = "Iron Ingot";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron has been used");
        }

    }
}