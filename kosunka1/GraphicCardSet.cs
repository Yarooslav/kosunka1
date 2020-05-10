using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosunka1
{
    class GraphicCardSet: CardSet
    {
        public Panel Panel { get; set; }

        public GraphicCardSet(Panel panel) : base()
        {
            Panel = panel;
        }

        public GraphicCardSet(Panel panel, int count):this(panel)
        {
            foreach (var figure in Enum.GetValues(typeof(CardFigure)))
            {
                foreach (var suit in Enum.GetValues(typeof(CardSuit)))
                {
                    Cards.Add(new GraphicCard((CardFigure)figure, (CardSuit)suit));
                }
            }
            if (count < Count)
                Cards.RemoveRange(0, Count - count);
        }

        public override void Show()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard graphicCard = (GraphicCard)Cards[i];
                PictureBox pb = graphicCard.Pb;
                Panel.Controls.Add(pb);
                pb.BringToFront();
                pb.Size = new Size(Panel.Height * pb.Image.Width/ pb.Image.Height, Panel.Height);
                pb.Location = new Point(i * (Panel.Width - pb.Width) / Cards.Count, 0);
                pb.TabIndex = i;
                pb.TabStop = false;
                graphicCard.Show();
            }

        }

    }
}
