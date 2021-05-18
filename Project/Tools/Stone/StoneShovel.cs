using System;

namespace Project
{
    class StoneShovel: Block, Crafted
    {
        private Recipe recipe;

        public StoneShovel(int newCount): base(newCount)
        {
            blockType = "Stone Shovel";
            classType = this;
            image = "img/StoneShovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Shovel has been placed");
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