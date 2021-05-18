using System;

namespace Project
{
    class GoldShovel: Block, Crafted
    {
        private Recipe recipe;

        public GoldShovel(int newCount): base(newCount)
        {
            blockType = "Gold Shovel";
            classType = this;
            image = "img/GoldShovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Shovel has been placed");
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