using System;

namespace Project
{
    class DiamondSword: Block, Crafted
    {
        private Recipe recipe;

        public DiamondSword(int newCount): base(newCount)
        {
            blockType = "DiamondSword";
            classType = this;
            image = "img/DiamondSword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Sword has been placed");
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