using System;

namespace Project
{
    class DiamondPickaxe: Block, Crafted
    {
        private Recipe recipe;

        public DiamondPickaxe(int newCount): base(newCount)
        {
            blockType = "DiamondPickaxe";
            classType = this;
            image = "img/DiamondPickaxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Pickaxe has been placed");
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