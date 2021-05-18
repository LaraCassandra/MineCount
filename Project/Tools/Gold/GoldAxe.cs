using System;

namespace Project
{
    class GoldAxe: Block, Crafted
    {
        private Recipe recipe;

        public GoldAxe(int newCount): base(newCount)
        {
            blockType = "Gold Axe";
            classType = this;
            image = "img/GoldAxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Axe has been placed");
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