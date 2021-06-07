using System;

namespace Project
{
    class Stick: Block, Crafted
    {

        private Recipe recipe;
        public Stick(int newCount): base(newCount)
        {
            blockType = "Stick";
            classType = this;
            image = "img/Stick.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stick has been used");
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