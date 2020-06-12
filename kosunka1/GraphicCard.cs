using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosunka1
{
    class GraphicCard: Card
    {
        public PictureBox Pb { get; set; }
        private Image imageCard; 
        private Image imageShirt;

        public bool Opened
        {
            get
            {
                return opened;
            }
            set
            {
                opened = value;
                Pb.Image = opened ? imageCard : imageShirt;
            }
        }

        private bool opened;
        private readonly string imageShirtPath = Application.StartupPath + @"\images\shirt.jpg";
        private readonly string fileName;

        public GraphicCard(CardFigure figure, CardSuit suit, PictureBox pb, bool opened = false) : base(figure, suit)
        {
            Pb = pb;
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
            Pb.Visible =false;
            fileName = Application.StartupPath + @"\images\" + this.ToString() + ".png";
            imageCard = Image.FromFile(fileName);
            imageShirt = Image.FromFile(imageShirtPath);
            Opened = opened;
        }

        public GraphicCard(CardFigure figure, CardSuit suit) : this(figure, suit, new PictureBox()) { }

        public override void Show()
        {
            Pb.Visible = true;
        }

        public override string ToString()
        {
            return String.Format($"{Suit}s {Figure}");
        }

    }
}
