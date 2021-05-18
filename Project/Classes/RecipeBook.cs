using System;
using System.Collections;

namespace Project
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();

        public static void Populate()
        {

            // WOOD RECIPES
            Recipe woodAxeRecipe = new Recipe((Crafted) WoodAxe.Get(), new Block[3,3] {{WoodBlock.Get(), WoodBlock.Get(), null},
                                                                                    {WoodBlock.Get(), Stick.Get(), null},
                                                                                    {null, Stick.Get(), null}});
            
            Recipe woodShovelRecipe = new Recipe((Crafted) WoodShovel.Get(), new Block[3,3]{{null, WoodBlock.Get(), null},
                                                                                            {null, Stick.Get(), null},
                                                                                            {null, Stick.Get(), null}});

            Recipe woodPickaxeRecipe = new Recipe((Crafted) WoodPickaxe.Get(), new Block[3,3]{{WoodBlock.Get(), WoodBlock.Get(), WoodBlock.Get()},
                                                                                            {null, Stick.Get(), null},
                                                                                            {null, Stick.Get(), null}});

            Recipe woodSwordRecipe = new Recipe((Crafted) WoodSword.Get(), new Block[3,3]{{null, WoodBlock.Get(), null},
                                                                                            {null, WoodBlock.Get(), null},
                                                                                            {null, Stick.Get(), null}});
            // ADD WOOD RECIPES TO ARRAY
            recipes.Add(woodAxeRecipe);
            recipes.Add(woodShovelRecipe);
            recipes.Add(woodPickaxeRecipe);
            recipes.Add(woodSwordRecipe);
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