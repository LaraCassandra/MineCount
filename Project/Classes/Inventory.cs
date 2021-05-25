using System;
using System.Collections;

namespace Project
{

    class Inventory 
    {
        private static ArrayList items = new ArrayList();

        public Inventory()
        {
            ArrayList data = Database.ReadBlocks();

            foreach (Tuple<string, int> curTuple in data)
            {
                Block newBlock;
                switch (curTuple.Item1)
                {
                    case "Stick":
                        newBlock = new Stick(curTuple.Item2);
                        break;
                    case "Coal":
                        newBlock = new Coal(curTuple.Item2);
                        break;
                    case "Torch":
                        newBlock = new Torch(curTuple.Item2);
                        break;
                    case "GlassBlock":
                        newBlock = new GlassBlock(curTuple.Item2);
                        break;
                    case "SandBlock":
                        newBlock = new SandBlock(curTuple.Item2);
                        break;

                    // WOOD TOOLS
                    case "Wood block":
                        newBlock = new WoodBlock(curTuple.Item2);
                        break;
                    case "WoodAxe":
                        newBlock = new WoodAxe(curTuple.Item2);
                        break;
                    case "WoodSword":
                        newBlock = new WoodSword(curTuple.Item2);
                        break;
                    case "WoodShovel":
                        newBlock = new WoodShovel(curTuple.Item2);
                        break;
                    case "WoodPickaxe":
                        newBlock = new WoodPickaxe(curTuple.Item2);
                        break;

                    // STONE TOOLS                    
                    case "CobblestoneBlock":
                        newBlock = new CobblestoneBlock(curTuple.Item2);
                        break;
                    case "StoneBlock":
                        newBlock = new StoneBlock(curTuple.Item2);
                        break;
                    case "StoneAxe":
                        newBlock = new StoneAxe(curTuple.Item2);
                        break;
                    case "StoneAPickaxe":
                        newBlock = new StonePickaxe(curTuple.Item2);
                        break;
                    case "StoneShovel":
                        newBlock = new StoneShovel(curTuple.Item2);
                        break;
                    case "StoneSword":
                        newBlock = new StoneSword(curTuple.Item2);
                        break;

                    // IRON TOOLS
                    case "IronOreBlock":
                        newBlock = new IronOreBlock(curTuple.Item2);
                        break;
                    case "IronIngot":
                        newBlock = new IronIngot(curTuple.Item2);
                        break;
                    case "IronAxe":
                        newBlock = new IronAxe(curTuple.Item2);
                        break;
                    case "IronPickaxe":
                        newBlock = new IronPickaxe(curTuple.Item2);
                        break;
                    case "IronShovel":
                        newBlock = new IronShovel(curTuple.Item2);
                        break;
                    case "IronSword":
                        newBlock = new IronSword(curTuple.Item2);
                        break;

                    // GOLD TOOLS
                    case "GoldOreBlock":
                        newBlock = new GoldOreBlock(curTuple.Item2);
                        break;
                    case "GoldIngot":
                        newBlock = new GoldIngot(curTuple.Item2);
                        break;
                    case "GoldAxe":
                        newBlock = new GoldAxe(curTuple.Item2);
                        break;
                    case "GoldPickaxe":
                        newBlock = new GoldPickaxe(curTuple.Item2);
                        break;
                    case "GoldShovel":
                        newBlock = new GoldShovel(curTuple.Item2);
                        break;
                    case "GoldSword":
                        newBlock = new GoldSword(curTuple.Item2);
                        break;

                    // DIAMOND TOOLS
                    case "Diamond":
                        newBlock = new Diamond(curTuple.Item2);
                        break;
                    case "DiamondAxe":
                        newBlock = new DiamondAxe(curTuple.Item2);
                        break;
                    case "DiamondPickaxe":
                        newBlock = new DiamondPickaxe(curTuple.Item2);
                        break;
                    case "DiamondShovel":
                        newBlock = new DiamondShovel(curTuple.Item2);
                        break;
                    case "DiamondSword":
                        newBlock = new DiamondSword(curTuple.Item2);
                        break;


                    default:
                        newBlock = null;
                        break;
                }
                items.Add(newBlock);
            }

            // ! HARD CODED
            // items.Add(new Coal(4));
            // items.Add(new Stick(1));
            // items.Add(new Torch(1));
            // items.Add(new GlassBlock(1));
            // items.Add(new SandBlock(1));

            // // WOOD ITEMS
            // items.Add(new WoodBlock(1));
            // items.Add(new WoodAxe(1));
            // items.Add(new WoodPickaxe(1));
            // items.Add(new WoodShovel(1));
            // items.Add(new WoodSword(1));

            // // STONE ITEMS
            // items.Add(new StoneBlock(1));
            // items.Add(new CobblestoneBlock(4));
            // items.Add(new StonePickaxe(1));
            // items.Add(new StoneAxe(1));
            // items.Add(new StoneShovel(1));
            // items.Add(new StoneSword(1));
            
            // // IRON ITEMS
            // items.Add(new IronIngot(1));
            // items.Add(new IronOreBlock(1));
            // items.Add(new IronPickaxe(1));
            // items.Add(new IronAxe(1));
            // items.Add(new IronShovel(1));
            // items.Add(new IronSword(1));

            // // GOLD ITEMS
            // items.Add(new GoldIngot(1));
            // items.Add(new GoldOreBlock(1));
            // items.Add(new GoldPickaxe(1));
            // items.Add(new GoldAxe(1));
            // items.Add(new GoldShovel(1));
            // items.Add(new GoldSword(1));

            // // DIAMOND ITEMS
            // items.Add(new Diamond(5));
            // items.Add(new DiamondPickaxe(1));
            // items.Add(new DiamondAxe(1));
            // items.Add(new DiamondShovel(1));
            // items.Add(new DiamondSword(1));
        }

        public ArrayList Items 
        {
            get
            {
                return items;
            }
        }

        public static Block GetClass(string index)
        {
            foreach(Block curItem in items)
            {
                if(curItem.BlockType == index)
                    return curItem;
            }

            return null;
        }
        
        public static int GetCount(string index)
        { 
            foreach (Block curItem in items)
            {
                if (index == curItem.BlockType)
                    return curItem.Count;
            }
            return -1;
        }
    }
}