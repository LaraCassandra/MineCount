using System;

namespace Project
{
    class WoodPickaxe: Block, Crafted
    {
        private Recipe recipe;

        public WoodPickaxe(int newCount): base(newCount)
        {
            blockType = "WoodPickaxe";
            classType = this;
            image = "img/WoodPickaxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Pickaxe has been placed");
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