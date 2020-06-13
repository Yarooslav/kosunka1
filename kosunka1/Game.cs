
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosunka1
{
    class Game
    {
        public CardSet Table { get; }
        public CardSet Deck { get; }
        public DownCardSet[] DownCardSets { get; }
        public TopCardSet[] TopCardSets { get; }
        public Action<bool> GameWon;
        private readonly int numOfCardForShowing;
        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public Game(CardSet table, CardSet deck,DownCardSet[] downCardSets, TopCardSet[] topCardSets, int numOfCardForShowing=3)
        {
            DownCardSets = downCardSets;
            TopCardSets = topCardSets;
            Table = table;
            Deck = deck;
            this.numOfCardForShowing = numOfCardForShowing;
        }

        public void Move(CardSet from, CardSet to, int amount)
        { 
            
            if (to.IsCoorect(from.Peek(amount)))
                to.Add(from.DealFromTop(amount));
            Refresh();
           
        }

        public void Refresh()
        {
            foreach (var item in TopCardSets)
            {
                item.Show();
            }
            foreach (var item1 in DownCardSets)
            {
                item1.Show();
            }
            Deck.Show();
            Table.Show();
        }

        public void DeckRepeat()
        {
            while (Table.Count != 0)
                Deck.Add(Table.Deal(1));
            Refresh();
        }

        public void ShowNewCrd()
        {
            Table.Add(Deck.Deal(numOfCardForShowing));
            Refresh();
        }
        public void Deal()
        {
            
            Deck.Mix();


            for (int i = 0; i < DownCardSets.Length; i++)
            {
                DownCardSets[i].Add(Deck.Deal(i+1));
            }

            ShowNewCrd();
        }
       
        protected void FireGameWonEvent()
        {
            //если выиграл
            GameWon(true);
        }

        public void HangUp()
        {
            Table.Cards.Clear();
            Refresh();
        }
    }
}
