using System;

namespace Project
{
    class WoodAxe: Block, Crafted
    {
        private Recipe recipe;

        public WoodAxe(int newCount): base(newCount)
        {
            blockType = "WoodAxe";
            classType = this;
            image = "img/WoodAxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("WoodAxe has been placed");
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