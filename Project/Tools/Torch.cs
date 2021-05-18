using System;

namespace Project
{
    class Torch: Block, Crafted
    {
        private Recipe recipe;

        public Torch(int newCount): base(newCount)
        {
            blockType = "Torch";
            classType = this;
            image = "img/Torch.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Torch has been placed");
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