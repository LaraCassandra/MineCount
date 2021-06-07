using System;

namespace Project
{
    class IronShovel: Block, Crafted
    {
        private Recipe recipe;

        public IronShovel(int newCount): base(newCount)
        {
            blockType = "IronShovel";
            classType = this;
            image = "img/IronShovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Shovel has been placed");
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