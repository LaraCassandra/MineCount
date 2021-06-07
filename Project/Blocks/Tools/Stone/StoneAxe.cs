using System;

namespace Project
{
    class StoneAxe: Block, Crafted
    {
        private Recipe recipe;

        public StoneAxe(int newCount): base(newCount)
        {
            blockType = "StoneAxe";
            classType = this;
            image = "img/StoneAxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Axe has been placed");
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