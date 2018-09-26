using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class Cards
    {
        public List<int> cards { get; set; }
        public int face { get; set; }

        public Cards()
        {
            cards = new List<int>();
        }
    }
}
