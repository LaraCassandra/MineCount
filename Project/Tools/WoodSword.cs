using System;

namespace Project
{
    class WoodSword: Block, Crafted
    {
        private Recipe recipe;

        public WoodSword(int newCount): base(newCount)
        {
            blockType = "Wood Sword";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Sword has been placed");
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