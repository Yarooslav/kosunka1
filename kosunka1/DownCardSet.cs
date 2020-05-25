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
            if (Count == 0 && newCards[0].Figure == CardFigure.King) return true;

            //первая карта должна быть другого цвета
            if (Cards[0].Color == newCards.LastCard.Color) return false;

            //значение первой карты должно быть на единицу меньше, чем последней в колоде
            if (Cards[0].Figure != newCards.LastCard.Figure - 1) return false;

            return true;

        }
    }
}
