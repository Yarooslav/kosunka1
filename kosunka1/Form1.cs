using System;
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

        public Form1()
        {
            InitializeComponent();
            TopCardSet[] tcs = { new GraphicTopCardSet(panel1), new GraphicTopCardSet(panel2), new GraphicTopCardSet(panel3), new GraphicTopCardSet(panel4) };
            DownCardSet[] dcs = { new GraphicDownCardSet(panel5),
                new GraphicDownCardSet(panel6),
                new GraphicDownCardSet(panel7),
                new GraphicDownCardSet(panel8),
                new GraphicDownCardSet(panel9),
                new GraphicDownCardSet(panel10),
                new GraphicDownCardSet(panel11) };
            game = new Game(new GraphicCardSet(panel13), new GraphicCardSet(panel12, 54), dcs, tcs);
            game.Move(game.Deck, game.Table, 3);

            foreach (var card in game.Deck.Cards)
            {
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.MouseDown += CardPictureBox_MouseDown;
                cardPictureBox.MouseMove += CardPictureBox_MouseMove;
                cardPictureBox.MouseUp += CardPictureBox_MouseUp;
                cardPictureBox.DoubleClick += CardPictureBox_DoubleClick1;
            }

            game.ShowMessage = ShowMessage;
            game.MarkActivePlayer = MarkPlayer;
            game.Deal();
            game.GameWon += Final;
        }

        private void CardPictureBox_DoubleClick1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CardPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CardPictureBox_MouseLeave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CardPictureBox_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void CardPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox cardPb = (PictureBox)sender;
            SetFromAmount(cardPb);

            activeCardSet = new GraphicDownCardSet(new Panel());
            activeCardSet.Add(from.Peek(activeamount));
            activeCardSet.Panel.Size = new Size(((GraphicDownCardSet)from).Panel.Width, ((GraphicDownCardSet)from).Panel.Width);
            label2.Text = e.Location.X.ToString() + " " + e.Location.Y.ToString();
            activeCardSet.Panel.MouseMove += Panel_MouseMove;
            activeCardSet.Panel.Location = ((GraphicDownCardSet)from).Panel.Location;
            panelForMoving = activeCardSet.Panel;
            startLocation = e.Location;
            this.Controls.Add(activeCardSet.Panel);
            activeCardSet.Show();
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left) return;

            if (from == null) return;

            if (activeamount <= 0) return;

            if ((Panel)sender != panelForMoving) return;

            activeCardSet.Panel.Location = e.Location;

            label1.Text = e.Location.X.ToString() + " " + e.Location.Y.ToString();

            //panelForMoving.Location.Offset(startLocation.X - e.X, startLocation.Y - e.Y);

            //panelForMoving.Top -= startLocation.Y - e.Y;
            //MessageBox.Show(activeCardSet.Panel.Location.X.ToString() + activeCardSet.Panel.Location.Y.ToString());
        }

        private void SetFromAmount(PictureBox cardPb)
        {
            int index = game.Table.Cards.FindIndex(c => c is GraphicCard && ((GraphicCard)c).Pb == cardPb);
            if (index != -1)
            {
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
          


            //MessageBox(W);

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
            //foreach (var player in game)
            //{
            //    foreach (var card in player.PlayerCards.Cards)
            //    {
            //        if (((GraphicCard)card).Pb == pictureBox)
            //        {
            //            if (card == to)
            //            {
            //                to = null;
            //                pictureBox.Top -= 10;
            //                from = null;
            //            }
            //            else
            //            {
            //                to = card;
            //                pictureBox.Top += 10;
            //                from = player;
            //            }


            //            return;
            //        }
            //    }
            //}
        }

        

        private void pnlTable_Click(object sender, EventArgs e)
        {

            if (to != null && from != null&& b!=null)
                game.Move(from,to,b);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
