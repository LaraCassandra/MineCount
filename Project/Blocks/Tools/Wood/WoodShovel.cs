using System;

namespace Project
{
    class WoodShovel: Block, Crafted
    {
        private Recipe recipe;

        public WoodShovel(int newCount): base(newCount)
        {
            blockType = "WoodShovel";
            classType = this;
            image = "img/WoodShovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("wood Shovel has been placed");
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