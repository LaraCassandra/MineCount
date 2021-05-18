using System;

namespace Project 
{
    class IronIngot : Block
    {
        public IronIngot(): base()
        {
            blockType = "Iron Ingot";
            classType = this;
            image = "img/IronIngot.png";
        }
        public IronIngot(int newCount): base(newCount)
        {
            blockType = "Iron Ingot";
            classType = this;
            image = "img/IronIngot.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron has been used");
        }

    }
}