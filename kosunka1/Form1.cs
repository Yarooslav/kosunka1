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

        CardSet to;
        Game game;
        CardSet from;
        int activeamount;
        int b = 54;

        GraphicDownCardSet activeCardSet;
        private Panel panelForMoving;
        private Point startLocation;
        PictureBox pbForMoving;

        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private void ShowTable()
        {
            foreach (var item in game.Table.Cards)
            {
                if (item is GraphicCard)
                    ((GraphicCard)item).Opened = true;
            };
        }

        private void CardPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox cardPb = (PictureBox)sender;
            if (game.Deck.Count == 0 || cardPb != ((GraphicCard)game.Deck.LastCard).Pb) return;
           
           game.ShowNewCrd();
            ShowTable();
        } 

        private void CardPictureBox_DoubleClick1(object sender, EventArgs e)
        {
            PictureBox cardPb = (PictureBox)sender;
            SetFromAmount(cardPb);
            foreach (var cardset in game.TopCardSets)
            {
                if (from != null && (cardset.Cards.Count == 0 || cardset.Cards[0].Suit == from.LastCard.Suit))
                {
                    game.Move(from, cardset, activeamount);
                    return;
                }
            }

        }

        private void CardPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (from == null || from.Count==0) return;
            if (activeamount <= 0) return;
            Rectangle r2 = new Rectangle() { Size = activeCardSet.Panel.Size, Location = activeCardSet.Panel.Location };
            foreach (var downCardSet in game.DownCardSets)
            {
                Rectangle r1 = new Rectangle() { Size = ((IGraphicsCardSet)downCardSet).Panel.Size, Location = ((GraphicDownCardSet)downCardSet).Panel.Location };

                if (r2.IntersectsWith(r1))
                {
                    to = downCardSet;
                    game.Move(from, to, activeamount);
                    break;
                }
            }

            activeamount = default;
            Controls.Remove(activeCardSet.Panel);
            activeCardSet = default;
            game.Refresh();
        }

       

        private void CardPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if ((PictureBox)sender != pbForMoving) return;
            if (from == null) return;

            activeCardSet.Panel.Left -= startLocation.X - e.X;

            activeCardSet.Panel.Top -= startLocation.Y - e.Y;
        }




        private void CardPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox cardPb = (PictureBox)sender;
            pbForMoving = cardPb;
            SetFromAmount(cardPb);
            if (from == null) return;

            CreateActiveCardSet();
            startLocation = e.Location;
            activeCardSet.Panel.Location = ((IGraphicsCardSet)from).Panel.Location.Plus(e.Location);
        }

        private void CreateActiveCardSet()
        {
            
            int cardSpace = 20;
            activeCardSet = new GraphicDownCardSet(new Panel());
            activeCardSet.Add(from.Peek(activeamount));
            activeCardSet.Panel.Size = new Size(panel1.Width, panel12.Height + cardSpace * activeamount);
            activeCardSet.Panel.MouseMove += Panel_MouseMove;
            
            panelForMoving = activeCardSet.Panel;
            this.Controls.Add(activeCardSet.Panel);
            activeCardSet.Panel.BringToFront();
            activeCardSet.Show();
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void SetFromAmount(PictureBox cardPb)
        {
            int index = game.Table.Cards.FindIndex(c => c is GraphicCard && ((GraphicCard)c).Pb == cardPb);
            if (index != -1)
            {
                if (cardPb != ((GraphicCard)game.Table.LastCard).Pb) return;

                from = game.Table;
                activeamount = 1;
                return;
            }

            from = game.DownCardSets.FirstOrDefault(
                dcs =>
                {
                    int index2 = dcs.Cards.FindIndex(c => c is GraphicCard && ((GraphicCard)c).Pb == cardPb);
                    if (index2 == -1) return false;
                    activeamount = dcs.Cards.Count - index2;
                    return true;
                }
                );
        }

        private void Final(bool IsWin)
        {

        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

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
            

        }

        private void SetActiveCard(PictureBox pictureBox)
        {
            
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pnlace_Paint(object sender, PaintEventArgs e)
        {
           
        }

       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            MessageBox.Show("opa F5");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void NewGame()
        {
            TopCardSet[] tcs = { new GraphicTopCardSet(panel1), new GraphicTopCardSet(panel2), new GraphicTopCardSet(panel3), new GraphicTopCardSet(panel4) };
            DownCardSet[] dcs = { new GraphicDownCardSet(panel5),
                new GraphicDownCardSet(panel6),
                new GraphicDownCardSet(panel7),
                new GraphicDownCardSet(panel8),
                new GraphicDownCardSet(panel9),
                new GraphicDownCardSet(panel10),
                new GraphicDownCardSet(panel11) };
            game = new Game(new GraphicCardSet(panel13), new GraphicCardSet(panel12, 54), dcs, tcs);
            game.Move(game.Deck, game.Table, activeamount);

            foreach (var card in game.Deck.Cards)
            {
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.MouseDown += CardPictureBox_MouseDown;
                cardPictureBox.MouseMove += CardPictureBox_MouseMove;
                cardPictureBox.MouseUp += CardPictureBox_MouseUp;
                cardPictureBox.DoubleClick += CardPictureBox_DoubleClick1;
                cardPictureBox.MouseClick += CardPictureBox_MouseClick;
            }

            game.ShowMessage = ShowMessage;
            game.MarkActivePlayer = MarkPlayer;
            game.Deal();
            ShowTable();
            game.GameWon += Final;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            game.DeckRepeat();
            HideDeck();
        }

        private void HideDeck()
        {
            foreach (var item in game.Deck.Cards)
            {
                if (item is GraphicCard)
                    ((GraphicCard)item).Opened = false;
            };
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
