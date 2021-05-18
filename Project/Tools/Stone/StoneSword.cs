using System;

namespace Project
{
    class StoneSword: Block, Crafted
    {
        private Recipe recipe;

        public StoneSword(int newCount): base(newCount)
        {
            blockType = "Stone Sword";
            classType = this;
            image = "img/StoneSword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Sword has been placed");
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