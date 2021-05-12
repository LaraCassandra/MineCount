using System;

namespace Project
{
    class Coal: Block, Flammable
    {
        public Coal(int newCount) : base(newCount)
        {
            blockType = "Coal resource";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Coal has been used");
        }

        public void Burn()
        {
            Count--;
            Console.WriteLine("Coal is burning");
        }
    }
}