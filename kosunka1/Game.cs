
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
        private DownCardSet[] downCards = new DownCardSet[7];
        private TopCardSet[] topCards = new TopCardSet[6];
        public Action<bool> GameWon;




        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public Game(CardSet table, CardSet deck,DownCardSet[] downCardSets, CardSet[] topCardSets)
        {
            downCards = downCardSets;
            topCardSets = topCardSets;
            Table = table;
            Deck = deck;
            
        }

        public void Move(CardSet from, CardSet to, int amount)
        { 


            //проверить возможен ли такой ход
            if (to.IsCoorect(from.Peek(amount)))
                to.Add(from.DealFromTop(amount));
            Refresh();
            //переложить карту, если возможно
            //рефреш
            // проверка вигрыша и проигрыша
        }

        public void Refresh()
        {
            foreach (var item in topCards)
            {
                item.Show();



            }
                            foreach (var item1 in downCards)
                {
                    item1.Show();


                }
            Table.Show();
        }



        //private Player PreviousPlayer(Player player)
        //{
        //    if (player == Players[0]) return Players[Players.Count - 1];

        //    return Players[Players.IndexOf(player) - 1];
        //}

        public void ShowNewCrd()
        {
            
        }
        public void Deal()
        {
            
            Deck.Mix();
            for (int i = 0; i < topCards.Length; i++)
            {
                topCards[i] = new TopCardSet();
            }

            for (int i = 0; i < topCards.Length; i++)
            {
                downCards[i] = new DownCardSet();
                downCards[i].Add(Deck.Deal(i));
            }

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
