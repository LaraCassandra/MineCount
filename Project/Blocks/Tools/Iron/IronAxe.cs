using System;

namespace Project
{
    class IronAxe: Block, Crafted
    {
        private Recipe recipe;

        public IronAxe(int newCount): base(newCount)
        {
            blockType = "IronAxe";
            classType = this;
            image = "img/IronAxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Axe has been placed");
        }

        public Recipe GetRecipe()
        {
            return recipe;
        }

        public void SetRecipe(Recipe newRecipe)
        {
            recipe = newRecipe;
        }
    }
}