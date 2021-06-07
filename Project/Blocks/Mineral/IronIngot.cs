using System;

namespace Project 
{
    class IronIngot : Block
    {
        public IronIngot(): base()
        {
            blockType = "IronIngot";
            classType = this;
            image = "img/IronIngot.png";
        }
        public IronIngot(int newCount): base(newCount)
        {
            blockType = "IronIngot";
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