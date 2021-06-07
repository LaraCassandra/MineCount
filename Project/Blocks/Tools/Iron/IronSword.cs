using System;

namespace Project
{
    class IronSword: Block, Crafted
    {
        private Recipe recipe;

        public IronSword(int newCount): base(newCount)
        {
            blockType = "IronSword";
            classType = this;
            image = "img/IronSword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Sword has been placed");
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