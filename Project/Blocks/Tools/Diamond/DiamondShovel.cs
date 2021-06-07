using System;

namespace Project
{
    class DiamondShovel: Block, Crafted
    {
        private Recipe recipe;

        public DiamondShovel(int newCount): base(newCount)
        {
            blockType = "DiamondShovel";
            classType = this;
            image = "img/DiamondShovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Shovel has been placed");
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