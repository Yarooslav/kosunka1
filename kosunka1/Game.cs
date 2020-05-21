
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
        //public Player ActivePlayer { get; set; }



        public Action<Player> MarkActivePlayer;
        public Action<string> ShowMessage;

        public Game(CardSet table, CardSet deck,CardSet pnlgame, params Player[] players)
        {
            Pnlgame = pnlgame;
            Table = table;
            Players = new List<Player>(players);
            Deck = deck;
            //ActivePlayer = players[0];
        }

        public void Move(CardSet from, CardSet to)
        {
            //проверить возможен ли такой ход
            //переложить карту, если возможно
            //рефреш
            // проверка вигрыша и проигрыша
        }

        public void Refresh()
        {
            foreach (var item in Players)
            {
                item.PlayerCards.Show();
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
            Pnlgame.Mix();
            Deck.Mix();
            foreach (var item in Players)
            {
                item.PlayerCards.Add(Deck.Deal(7),Pnlgame.Deal(1));
               
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

        public void HangUp()
        {
            Table.Cards.Clear();
            Refresh();
        }
    }
}
