using System;

namespace Project
{
    class GoldPickaxe: Block, Crafted
    {
        private Recipe recipe;

        public GoldPickaxe(int newCount): base(newCount)
        {
            blockType = "Gold Pickaxe";
            classType = this;
            image = "img/GoldPickaxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Pickaxe has been placed");
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