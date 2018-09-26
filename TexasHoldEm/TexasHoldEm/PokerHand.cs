using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class PokerHand
    {
        public List<int> handCards { get; private set; }
        public List<int> otherCards { get; private set; }

        public PokerHand(List<int> cards)
        {
            handCards = cards;
            otherCards = new List<int>();
        }

        public void addHand(List<int> cards)
        {
            foreach(var card in cards)
            {
                otherCards.Add(card);
            }
        }
    }
}
