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
            items.Add(new GlassBlock(1));
            items.Add(new SandBlock(6));
            items.Add(new WoodBlock(10));
            items.Add(new Stick(1));
            items.Add(new WoodAxe(8));
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
                if (curItem.BlockType == index)
                    return curItem.Count;
            }
            return -1;
        }
    }
}