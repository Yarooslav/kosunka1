﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosunka1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            game = new Game(new GraphicCardSet(pnlTable), new GraphicCardSet(pnlDeck,54), new GraphicCardSet(downpanel, 7), new GraphicCardSet(toppanel, 5));
            game.GameWon += Final;
        }

        CardSet to;
        Game game;
        CardSet from;
        int b = 54;

        private void Final(bool IsWin)
        {
            //long n;
            //for (n = 9; n < 13; n++)
            //{
            //    if (IsWin(n) != 13) return false;

            //}
            //return true;

        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //game = new Game(new GraphicCardSet(pnlTable), new GraphicCardSet(pnlDeck, 54),
            //       new Player("Bob", new GraphicCardSet(pnlPlayer1)));

            //foreach (var card in game.Deck.Cards)
            //{
            //    PictureBox cardPictureBox = ((GraphicCard)card).Pb;
            //    cardPictureBox.DoubleClick += CardPictureBox_DoubleClick;
            //    cardPictureBox.Click += CardPictureBox_Click;
            //}

            //game.ShowMessage = ShowMessage;
            //game.MarkActivePlayer = MarkPlayer;

            //game.Deal();

        }

        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            SetActiveCard(pictureBox);
        }

        private void CardPictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (to != null)
            {
                game.Move(from, to,b);
            }
        }
        private void ShowMessage(string message)
        {
            lbl.Text = message;
        }
        private void MarkPlayer(Player activePlayer)
        {
            //foreach (var player in game.Players)
            //{
            //    if (player == activePlayer)
            //        foreach (var card in player.PlayerCards.Cards)
            //        {
            //            GraphicCard graphicCard = (GraphicCard)card;
            //            graphicCard.Opened = true;
            //        }
            //    else
            //        foreach (var card in player.PlayerCards.Cards)
            //        {
            //            GraphicCard graphicCard = (GraphicCard)card;
            //            graphicCard.Opened = true;
            //        }

            //}
            //game.Refresh();

        }



        private void SetActiveCard(PictureBox pictureBox)
        {
            foreach (var player in game)
            {
                foreach (var card in player.PlayerCards.Cards)
                {
                    if (((GraphicCard)card).Pb == pictureBox)
                    {
                        if (card == to)
                        {
                            to = null;
                            pictureBox.Top -= 10;
                            from = null;
                        }
                        else
                        {
                            to = card;
                            pictureBox.Top += 10;
                            from = player;
                        }


                        return;
                    }
                }
            }
        }

        

        private void pnlTable_Click(object sender, EventArgs e)
        {

            if (to != null && from != null&& b!=null)
                game.Move(from,to,b);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            game = new Game(new GraphicCardSet(pnlTable), new GraphicCardSet(pnlDeck, 54), new GraphicCardSet(downpanel, 7), new GraphicCardSet(toppanel, 5));

            foreach (var card in game.Deck.Cards)
            {
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.DoubleClick += CardPictureBox_DoubleClick;
                cardPictureBox.Click += CardPictureBox_Click;
            }
            foreach (var card in game.Table.Cards)
            {
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.DoubleClick += CardPictureBox_DoubleClick;
                cardPictureBox.Click += CardPictureBox_Click;
            }

            game.ShowMessage = ShowMessage;
            game.MarkActivePlayer = MarkPlayer;

            game.Deal();
        }

        private void Pnlace_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pnlPlayer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
