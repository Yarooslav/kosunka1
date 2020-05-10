using System;
using System.Collections.Generic;
using System.Text;

namespace kosunka1
{
    public enum CardFigure
    {
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum CardSuit
    {
        Diamond,
        Club,
        Heart,
        Spade
    }
    class Card
    {
        public CardFigure Figure { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardFigure figure, CardSuit suit)
        {
            Figure = figure;
            Suit = suit;
        }

        public virtual void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Figure, Suit);
        }
    }
}
