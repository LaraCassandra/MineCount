using System;
using System.Collections;

namespace Project
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();

        public static void Populate()
        {

            ArrayList records = Database.ReadRecipes();

            foreach(Tuple<string, string[,]> curTuple in records)
            {
                Recipe curRecipe = new Recipe((Crafted) Inventory.GetClass(curTuple.Item1), new Block[3,3]
                    {{Inventory.GetClass(curTuple.Item2[0,0]), Inventory.GetClass(curTuple.Item2[0,1]), Inventory.GetClass(curTuple.Item2[0,2])},
                    {Inventory.GetClass(curTuple.Item2[1,0]), Inventory.GetClass(curTuple.Item2[1,1]), Inventory.GetClass(curTuple.Item2[1,2])},
                    {Inventory.GetClass(curTuple.Item2[2,0]), Inventory.GetClass(curTuple.Item2[2,1]), Inventory.GetClass(curTuple.Item2[2,2])}});
                recipes.Add(curRecipe);
            }

            // ! HARD CODED
            // // ! WOOD RECIPES
            // Recipe woodAxeRecipe = new Recipe((Crafted) WoodAxe.Get(), new Block[3,3] {{WoodBlock.Get(), WoodBlock.Get(), null},
            //                                                                         {WoodBlock.Get(), Stick.Get(), null},
            //                                                                         {null, Stick.Get(), null}});
            
            // Recipe woodShovelRecipe = new Recipe((Crafted) WoodShovel.Get(), new Block[3,3]{{null, WoodBlock.Get(), null},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe woodPickaxeRecipe = new Recipe((Crafted) WoodPickaxe.Get(), new Block[3,3]{{WoodBlock.Get(), WoodBlock.Get(), WoodBlock.Get()},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe woodSwordRecipe = new Recipe((Crafted) WoodSword.Get(), new Block[3,3]{{null, WoodBlock.Get(), null},
            //                                                                                 {null, WoodBlock.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});
            // // ADD WOOD RECIPES TO ARRAY
            // recipes.Add(woodAxeRecipe);
            // recipes.Add(woodShovelRecipe);
            // recipes.Add(woodPickaxeRecipe);
            // recipes.Add(woodSwordRecipe);

            // // ! STONE RECIPES
            // Recipe stoneAxeRecipe = new Recipe((Crafted) StoneAxe.Get(), new Block[3,3] {{CobblestoneBlock.Get(), CobblestoneBlock.Get(), null},
            //                                                                         {CobblestoneBlock.Get(), Stick.Get(), null},
            //                                                                         {null, Stick.Get(), null}});
            
            // Recipe stoneShovelRecipe = new Recipe((Crafted) StoneShovel.Get(), new Block[3,3]{{null, CobblestoneBlock.Get(), null},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe stonePickaxeRecipe = new Recipe((Crafted) StonePickaxe.Get(), new Block[3,3]{{CobblestoneBlock.Get(), CobblestoneBlock.Get(), CobblestoneBlock.Get()},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe stoneSwordRecipe = new Recipe((Crafted) StoneSword.Get(), new Block[3,3]{{null, CobblestoneBlock.Get(), null},
            //                                                                                 {null, CobblestoneBlock.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});
            // // ADD STONE RECIPES TO ARRAY
            // recipes.Add(stoneAxeRecipe);
            // recipes.Add(stoneShovelRecipe);
            // recipes.Add(stonePickaxeRecipe);
            // recipes.Add(stoneSwordRecipe);

            // // ! IRON RECIPES
            // Recipe ironAxeRecipe = new Recipe((Crafted) IronAxe.Get(), new Block[3,3] {{IronIngot.Get(), IronIngot.Get(), null},
            //                                                                         {IronIngot.Get(), Stick.Get(), null},
            //                                                                         {null, Stick.Get(), null}});
            
            // Recipe ironShovelRecipe = new Recipe((Crafted) IronShovel.Get(), new Block[3,3]{{null, IronIngot.Get(), null},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe ironPickaxeRecipe = new Recipe((Crafted) IronPickaxe.Get(), new Block[3,3]{{IronIngot.Get(), IronIngot.Get(), IronIngot.Get()},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe ironSwordRecipe = new Recipe((Crafted) IronSword.Get(), new Block[3,3]{{null, IronIngot.Get(), null},
            //                                                                                 {null, IronIngot.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});
            // // ADD IRON RECIPES TO ARRAY
            // recipes.Add(ironAxeRecipe);
            // recipes.Add(ironShovelRecipe);
            // recipes.Add(ironPickaxeRecipe);
            // recipes.Add(ironSwordRecipe);

            // // ! GOLD RECIPES
            // Recipe goldAxeRecipe = new Recipe((Crafted) GoldAxe.Get(), new Block[3,3] {{GoldIngot.Get(), GoldIngot.Get(), null},
            //                                                                         {GoldIngot.Get(), Stick.Get(), null},
            //                                                                         {null, Stick.Get(), null}});
            
            // Recipe goldShovelRecipe = new Recipe((Crafted) GoldShovel.Get(), new Block[3,3]{{null, GoldIngot.Get(), null},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe goldPickaxeRecipe = new Recipe((Crafted) GoldPickaxe.Get(), new Block[3,3]{{GoldIngot.Get(), GoldIngot.Get(), GoldIngot.Get()},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe goldSwordRecipe = new Recipe((Crafted) GoldSword.Get(), new Block[3,3]{{null, GoldIngot.Get(), null},
            //                                                                                 {null, IronIngot.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});
            // // ADD GOLD RECIPES TO ARRAY
            // recipes.Add(goldAxeRecipe);
            // recipes.Add(goldShovelRecipe);
            // recipes.Add(goldPickaxeRecipe);
            // recipes.Add(goldSwordRecipe);

            // // ! DIAMOND RECIPES
            // Recipe diamondAxeRecipe = new Recipe((Crafted) DiamondAxe.Get(), new Block[3,3] {{Diamond.Get(), Diamond.Get(), null},
            //                                                                         {Diamond.Get(), Stick.Get(), null},
            //                                                                         {null, Stick.Get(), null}});
            
            // Recipe diamondShovelRecipe = new Recipe((Crafted) DiamondShovel.Get(), new Block[3,3]{{null, Diamond.Get(), null},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe diamondPickaxeRecipe = new Recipe((Crafted) DiamondPickaxe.Get(), new Block[3,3]{{Diamond.Get(), Diamond.Get(), Diamond.Get()},
            //                                                                                 {null, Stick.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});

            // Recipe diamondSwordRecipe = new Recipe((Crafted) DiamondSword.Get(), new Block[3,3]{{null, Diamond.Get(), null},
            //                                                                                 {null, Diamond.Get(), null},
            //                                                                                 {null, Stick.Get(), null}});
            // // ADD DIAMOND RECIPES TO ARRAY
            // recipes.Add(diamondAxeRecipe);
            // recipes.Add(diamondShovelRecipe);
            // recipes.Add(diamondPickaxeRecipe);
            // recipes.Add(diamondSwordRecipe);

            // // ! TORCH RECIPE
            // Recipe torchRecipe = new Recipe((Crafted) Torch.Get(), new Block[2,2] {{Coal.Get(), null},
            //                                                                         {Stick.Get(), null}});
            // recipes.Add(torchRecipe);

            // // ! STICK RECIPE
            // Recipe stickRecipe = new Recipe((Crafted) Stick.Get(), new Block[2,2] {{WoodBlock.Get(), null},
            //                                                                         {WoodBlock.Get(), null}});
            // recipes.Add(stickRecipe);
        }

        public static ArrayList Recipes
        {
            get
            {
                return recipes;
            }
        }

        public static void AddRecipe(Recipe recipe)
        {
            string blockType = recipe.Result.BlockType;

            bool newRecipe = true;
            foreach (Recipe curRecipe in recipes)
            {
                if (curRecipe.Result.BlockType == blockType)
                    newRecipe = false;
            }

            if (newRecipe == true)
            {
                recipes.Add(recipe);
            }
        }
    }
}