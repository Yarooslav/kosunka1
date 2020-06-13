using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosunka1
{
    class Player
    {
        public string Name { get; set; }
        public CardSet PlayerCards { get; set; }
        public Player(string name)
        {
            Name = name;
        }


        public Player(string name, CardSet cardSet) : this(name)
        {
            PlayerCards = cardSet;
        }
    }
}
