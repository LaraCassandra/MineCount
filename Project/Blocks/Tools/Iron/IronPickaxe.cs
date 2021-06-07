using System;

namespace Project
{
    class IronPickaxe: Block, Crafted
    {
        private Recipe recipe;

        public IronPickaxe(int newCount): base(newCount)
        {
            blockType = "IronPickaxe";
            classType = this;
            image = "img/IronPickaxe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Pickaxe has been placed");
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