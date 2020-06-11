using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosunka1
{
    class GraphicDownCardSet:DownCardSet, IGraphicsCardSet
    {
        public Panel Panel { get; set; }

        public GraphicDownCardSet(Panel panel) : base()
        {
            Panel = panel;
        }

        public override void Show()
        {
            int dy = 20;
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard graphicCard = (GraphicCard)Cards[i];
                PictureBox pb = graphicCard.Pb;
                Panel.Controls.Add(pb);
                pb.BringToFront();
                pb.Size = new Size(Panel.Width, Panel.Width * pb.Image.Height / pb.Image.Width);
                pb.Location = new Point(0,  (Panel.Height - pb.Height) / Cards.Count < dy ? i * (Panel.Height - pb.Height) / Cards.Count : i * dy);
                pb.TabIndex = i;
                pb.TabStop = false;
                graphicCard.Opened = graphicCard.Opened || i == Cards.Count - 1;
                graphicCard.Show();
            }

        }
    }
}
