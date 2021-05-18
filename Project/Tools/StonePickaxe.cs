using System;

namespace Project
{
    class StonePickaxe: Block, Crafted
    {
        private Recipe recipe;

        public StonePickaxe(int newCount): base(newCount)
        {
            blockType = "Stone Pickaxe";
            classType = this;
            image = "img/StonePickaxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Pickaxe has been placed");
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