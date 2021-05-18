using System;

namespace Project
{
    class GoldSword: Block, Crafted
    {
        private Recipe recipe;

        public GoldSword(int newCount): base(newCount)
        {
            blockType = "Gold Sword";
            classType = this;
            image = "img/GoldSword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Sword has been placed");
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