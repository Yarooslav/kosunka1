using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosunka1
{
    class GraphicDownCardSet:DownCardSet
    {
        public Panel Panel { get; set; }

        public GraphicDownCardSet(Panel panel) : base()
        {
            Panel = panel;
        }

        public override void Show()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard graphicCard = (GraphicCard)Cards[i];
                PictureBox pb = graphicCard.Pb;
                Panel.Controls.Add(pb);
                pb.BringToFront();
                pb.Size = new Size(Panel.Width, Panel.Height * pb.Image.Width / pb.Image.Width);
                pb.Location = new Point(0, i * (Panel.Width - pb.Width) / Cards.Count);
                pb.TabIndex = i;
                pb.TabStop = false;
                graphicCard.Opened = i == Cards.Count - 1;
                graphicCard.Show();
            }

        }
    }
}
