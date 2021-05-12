using System;
using System.Collections;

namespace Project
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();

        public static void Populate()
        {
            Recipe axeRecipe = new Recipe((Crafted) WoodAxe.Get(), new Block[3,3] {{WoodBlock.Get(), WoodBlock.Get(), null},
                                                                                    {WoodBlock.Get(), Stick.Get(), null},
                                                                                    {null, Stick.Get(), null}});
            recipes.Add(axeRecipe);
        }

        public static ArrayList Recipes
        {
            get
            {
                return recipes;
            }
        }
    }
}