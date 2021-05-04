        class Block 
        {
            public Block(string name, int amount)
            {
                this.name = name;
                this.amount = amount;
            }

            private string name;
            private int amount;

            public string Name 
            {
                get {return name;}
                set {name = value;}
            }

            public int Amount 
            {
                get {return amount;}
                set {amount = value;}
            }
        
        }