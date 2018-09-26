using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Dice
    {
        public List<int> die = new List<int>();
        public bool[] saved = new bool[5];

        public Dice()
        {
            for(int a = 0; a<5; a++)
            {
                die.Add(0);
                saved[a] = false;
            }
        }
    }
}
