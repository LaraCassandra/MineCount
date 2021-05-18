using System;
using System.Collections;

namespace Project
{

    class Inventory 
    {
        private static ArrayList items = new ArrayList();

        public Inventory()
        {
            items.Add(new Coal(4));
            items.Add(new Diamond(5));
            items.Add(new GlassBlock(1));
            items.Add(new GoldIngot(1));
            items.Add(new GoldOreBlock(1));
            items.Add(new IronIngot(1));
            items.Add(new IronOreBlock(1));
            items.Add(new SandBlock(1));
            items.Add(new Stick(1));

            // WOOD ITEMS
            items.Add(new WoodBlock(1));
            items.Add(new WoodAxe(1));
            items.Add(new WoodPickaxe(1));
            items.Add(new WoodShovel(1));
            items.Add(new WoodSword(1));

            // STONE ITEMS
            items.Add(new StoneBlock(1));
            items.Add(new CobblestoneBlock(4));
            items.Add(new StonePickaxe(1));
            items.Add(new StoneAxe(1));
            items.Add(new StoneShovel(1));
            items.Add(new StoneSword(1));

        }

        public ArrayList Items 
        {
            get
            {
                return items;
            }
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