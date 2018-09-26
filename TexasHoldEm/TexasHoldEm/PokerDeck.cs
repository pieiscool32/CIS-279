using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class PokerDeck
    {
        public List<int> cards { get; private set; }
        
        public PokerDeck(INumberGenerator _gen)
        {
            cards = new List<int>();
            for(int card = 0; card < 52; card++)
            {
                int next = _gen.Next(1, 53);
                while (cards.Contains(next))
                {
                    next = _gen.Next(1, 53);
                }
                cards.Add(next);
            }
        }
    }
}
