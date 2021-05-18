using System;

namespace Project
{
    class DiamondAxe: Block, Crafted
    {
        private Recipe recipe;

        public DiamondAxe(int newCount): base(newCount)
        {
            blockType = "Diamond Axe";
            classType = this;
            image = "img/DiamondAxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Axe has been placed");
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