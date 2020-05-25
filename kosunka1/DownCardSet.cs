using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosunka1
{
    class DownCardSet: CardSet
    {
        public  CardSet Downcard { get; set; }
        public bool override IsCoorect(Card card)
        {
            //можно ли ее сюда класть?
        }
    }
}
