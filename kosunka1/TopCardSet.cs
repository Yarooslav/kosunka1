using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosunka1
{
    class TopCardSet:CardSet
    {
        public override bool IsCoorect(CardSet newCards)
        {
            //на пустую можно класть только Туза
            if (Count == 0)
                if (newCards[0].Figure == CardFigure.Ace) return true;
                else return false;

            //первая карта должна быть одинакового цвета
            if (Cards[0].Color == newCards.LastCard.Color) return false;

            //значение первой карты должно быть на единицу больше, чем последней в колоде
            if (Cards[0].Figure != newCards.LastCard.Figure + 1) return false;

            return true;

        }
    }
}
