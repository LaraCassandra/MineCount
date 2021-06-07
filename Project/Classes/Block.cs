using System;

namespace Project
{
    abstract class Block 
    {
        private int count;
        protected string blockType;
        protected string image;

        protected static Block classType;
    
        public int Count
        {
            get 
            {
                return count;
            }
            set
            {
                if (value < 0)
                    count = -value;
                else
                    count = value;

            }
        }

        public string BlockType
        {
            get 
            {
                return blockType;
            }
        }

        public string Image
        {
            get
            {
                return image;
            }
        }

        public Block()
        {
            count = 0;
        }

        public Block (int newCount)
        {
            count = newCount;
        }

        public abstract void Place();

        public static Block Get()
        {
            return classType;
        }

    }
}