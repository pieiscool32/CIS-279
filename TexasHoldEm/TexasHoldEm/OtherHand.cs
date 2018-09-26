using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class OtherHand
    {
        private PokerScore _score;
        private List<int> _hand;

        public string name { get; private set; }
        public string handType { get; private set; }
        public bool canPlay { get; set; }
        public int index { get; private set; }
        public int bestScore { get; private set; }
        public int highCard { get; private set; }
        public int averageScore { get; private set; }
        public int numCombos { get; private set; }
        public int bestOtherScore { get; private set; }
        public int averageOtherScore { get; private set; }
        public int numOtherCombos { get; private set; }
        public double winOdds { get; private set; }
        public double numBeat { get; private set; }
        public double numLose { get; private set; }
        public List<int> highlight { get; private set; }

        public OtherHand(string _name, int _index)
        {
            name = _name;
            index = _index;
        }

        public void FindOdds(List<int> deck, List<int> table, List<int> hold)
        {
            _hand = new List<int>();
            //add cards to your 'hand'
            foreach (var card in table)
            {
                _hand.Add(card);
            }
            _hand.Add(hold[0]);
            _hand.Add(hold[1]);

            //reset
            handType = null;
            numCombos = 1;
            numOtherCombos = 1;
            numLose = 0;
            numBeat = 0;
            bestScore = 0;
            averageScore = 0;
            bestOtherScore = 0;
            averageOtherScore = 0;
            highCard = 0;
            highlight = new List<int>();

            //get the best possible score
            foreach (var combo in Combinations<int>.Combine(_hand, 5))
            {
                _score = new PokerScore(combo);
                if (_score.score > bestScore)
                {
                    bestScore = _score.score;
                    highCard = _score.highCard;
                    highlight = _score.highlight;
                    handType = _score.kind;
                }
                averageScore = averageScore + (_score.score - averageScore) / numCombos;
                numCombos++;
            }
            numCombos--; //to offset divide by 0 fix

            //for each other 2 possible card combination
            foreach (var combo in Combinations<int>.Combine(deck, 2))
            {
                //now add those to your 'hand'
                _hand[table.Count-2] = combo[0];
                _hand[table.Count-1] = combo[1];
                int highest = 0;
                //find the best possile score for your 'hand'
                foreach(var hand in Combinations<int>.Combine(_hand, 5))
                {
                    _score = new PokerScore(combo);
                    bestOtherScore = bestOtherScore > _score.score ? bestOtherScore : _score.score;
                    averageOtherScore = averageOtherScore + (_score.score - averageOtherScore) / numOtherCombos;
                    highest = _score.score > highest ? +_score.score : highest;
                }
                numOtherCombos++;
                numBeat = highest < bestScore ? numBeat + 1 : numBeat;
                numLose = highest > bestScore ? numLose + 1 : numLose;
            }
            numOtherCombos--; //to offset divide by 0 fix

            //get the odds of you winning
            winOdds = numBeat / (double)numOtherCombos;
            winOdds = Math.Round(winOdds, 4);
            winOdds = winOdds > 1 ? 0 : winOdds; //too big?
            winOdds = winOdds < 0 ? 0 : winOdds; //too small?
        }
    }
}
