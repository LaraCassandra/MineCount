using System;
using System.Collections.Generic;

namespace Project
{
    class Recipe{
        private Block[,] inputs;
        private Crafted result;

        public Recipe(Crafted newResult, Block[,] newInputs)
        {
            inputs = newInputs;
            result = newResult;
            result.SetRecipe(this);
        }

        public Block[,] Inputs 
        {
            get
            {
                return inputs;
            }
        }

        public Block Result
        {
            get
            {
                return (Block) result;
            }
        }
    }
}