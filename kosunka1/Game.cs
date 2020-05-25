
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
        public CardSet DownCardSet { get; }
        public CardSet TopCardSet { get; }
        public CardSet Table { get; }
        public CardSet Deck { get; }
        private DownCardSet[] downCards = new DownCardSet[7];
        private TopCardSet[] topCards = new TopCardSet[5];
        public event Action GameWon;




        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public Game(CardSet table, CardSet deck,CardSet downCards, CardSet topCards)
        {
            DownCardSet = downCards;
            TopCardSet = topCards;
            Table = table;
            Deck = deck;
            
        }

        public void Move(CardSet from, CardSet to)
        { if (from.Cards.IndexOf(to) == 0) return;
            //Table.Add(from.Pull(to));
            TopCardSet.Add(from.Pull(5));
           DownCardSet.Add(from.Pull(7));
            Refresh();
            //проверить возможен ли такой ход
            //переложить карту, если возможно
            //рефреш
            // проверка вигрыша и проигрыша
        }

        public void Refresh()
        {
            foreach (var item in topCards)
            {
                item.Topcard.Show();

                foreach (var item1 in downCards)
                {
                    item1.Downcard.Show();


                }

            }
            Table.Show();
        }



        //private Player PreviousPlayer(Player player)
        //{
        //    if (player == Players[0]) return Players[Players.Count - 1];

        //    return Players[Players.IndexOf(player) - 1];
        //}

        public void Deal()
        {
            
            Deck.Mix();
            foreach (var item in topCards)
            {
                item.Topcard.Add(Deck.Deal(7));
               
            }
            foreach (var item in downCards)
            {
                item.Downcard.Add(Deck.Deal(5));

            }
            //for (int n = 0; n < 7; n++)
            //{
            //    long amount = GraphicCard(n+2);
            //    if (amount > 0) Panel[n + 2][amount - 1].Visible = false;
            //}
            Refresh();
        }
        //public void GameOver()
        //{
        //    foreach (var item in Players)
        //    {
        //        if (item.PlayerCards.Cards.Count != 0)
        //            ShowMessage(item.Name + "loose");
        //    }
        //}
        protected void FireGameWonEvent()
        {
            Action wonEvent = GameWon;
            if (wonEvent != null)
                wonEvent();
        }

        public void HangUp()
        {
            Table.Cards.Clear();
            Refresh();
        }
    }
}
