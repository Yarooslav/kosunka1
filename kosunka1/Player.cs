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
        //public CardSuit Suit
        //{
        //    get
        //    {
        //        int enumVal = (int)CardFigure;
        //        if (enumVal < 13)
        //            return CardSuit.Heart;
        //        if (enumVal < 26)
        //            return CardSuit.Diamond;
        //        if (enumVal < 39)
        //            return CardSuit.Club;
        //        return CardSuit.Spade;
        //    }
        //}

        public Player(string name, CardSet cardSet):this(name)
        {
            PlayerCards = cardSet;
        }
    }
}
