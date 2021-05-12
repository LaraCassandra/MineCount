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
            items.Add(new Stick(0));
        }

        public ArrayList Items 
        {
            get
            {
                return items;
            }
        }
    }
}