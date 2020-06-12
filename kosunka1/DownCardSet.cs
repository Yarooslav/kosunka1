using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosunka1
{
    class DownCardSet: CardSet
    {
        public override bool IsCoorect(CardSet newCards)
        {
            //на пустую можно класть только Короля
            if (Count == 0)
                if (newCards[0].Figure == CardFigure.King) return true;
                else return false;

            //первая карта должна быть другого цвета
            if (LastCard.Color == newCards[0].Color) return false;

            //значение первой карты должно быть на единицу меньше, чем последней в колоде
            if (LastCard.Figure-1 != newCards[0].Figure) return false;

            return true;

        }
    }
}
