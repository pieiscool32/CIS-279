using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public interface INumberGenerator
    {
        int Next(int min, int max);
    }

    public class NumberGen : INumberGenerator
    {
        private List<int> _generate;
        private int _numGenerated;

        public NumberGen(List<int> toGenerate)
        {
            _generate = toGenerate;
            _numGenerated = 0;
        }

        public int Next(int min, int max)
        {
            return _generate[_numGenerated++ % _generate.Count];
        }
    }

    public class RandomGen : INumberGenerator
    {
        private Random _rand;

        public RandomGen()
        {
            _rand = new Random();
        }

        public int Next(int min, int max)
        {
            return _rand.Next(min, max);
        }
    }
}
