using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    /* Hand Type Guide (per index)
     1 = Pair              2 = Two Pair
     3 = Three of a Kind   4 = Stright
     5 = Flush             6 = Full House
     7 = Four of a Kind    8 = Sraight Flush
    */
    public class PokerScore
    {
        public int score { get; private set; }
        public int highCard { get; private set; }
        public string kind { get; private set; }
        public List<int> highlight { get; private set; }

        private List<int> _cards { set; get; }
        private List<int> primes = new List<int>() { 3, 5, 7, 9, 11, 13, 17, 19, 23 };
        private List<int> _spade = new List<int>() { 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 1 };
        private List<int> _ace = new List<int>() { 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 2 };
        private List<int> _heart = new List<int>() { 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 3 };
        private List<int> _diamond = new List<int>() { 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 4 };
        //used to find the number of cards, what cards are stored, and face value
        private List<Cards> _face = new List<Cards>();

        public PokerScore(List<int> cards)
        {
            highlight = new List<int>();
            _cards = cards;
            _face = new List<Cards>(cardNums());
            highCard = topCard();

            kind = "Nothing";
            if (FullHouse())
            {
                kind = "Full House";
            }
            else if (ThreeOfAKind())
            {
                kind = "Three of a Kind";
            } 
            else if (Pair())
            {
                kind = "Pair";
            }
            if (TwoPair()) kind = "Two Pairs";
            if (FourOfAKind()) kind = "Four of a Kind";
            if (StrightFlush())
            {
                kind = "Straight Flush";
            }
            else if (Flush())
            {
                kind = "Flush";
            }
            else if (Stright())
            {
                kind = "Straight";
            }
        }

        private bool allSuit(List<int> suit)
        {
            foreach (int card in _cards)
            {
                if (!suit.Contains(card))
                {
                    return false;
                }
            }
            return true;
        }

        private List<Cards> cardNums()
        {
            //puts the face value of each card into a list
            List<Cards> _card = new List<Cards>();
            for(int index = 0; index < 13; index++)
            {
                _card.Add(new Cards());
                _card[index].face = index + 2; //+2 due to index type
            }

            for (int index = 0; index < _cards.Count; index++)
            {
                for (int card = 0; card < _spade.Count; card++)
                {
                    if (_cards[index] == _spade[card] || _cards[index] == _ace[card] ||
                        _cards[index] == _diamond[card] || _cards[index] == _heart[card])
                    {
                        _card[card].cards.Add(_cards[index]);
                    }
                }
            }
            return _card;
        }

        private int topCard()
        {
            int top = 0;
            foreach(var card in _face)
            {
                top = card.face > top ? card.face : top;
            }
            return top;
        }

        public bool Pair()
        {
            int biggest = 0;
            for (int index = 0; index < _face.Count; index++)
            {
                if (_face[index].cards.Count == 2 && index >= biggest) biggest = index;
            }
            if(biggest != 0)
            {
                score = 1;
                foreach (var card in _face[biggest].cards)
                {
                    highlight.Add(card);
                }
            }
            return biggest == 0 ? false : true;
        }

        public bool TwoPair()
        {
            int pair = 0;
            List<int> temp = new List<int>();
            for (int index = 0; index < _face.Count; index++)
            {
                if (_face[index].cards.Count == 2)
                {
                    pair++;
                    foreach(var card in _face[index].cards)
                    {
                        temp.Add(card);
                    }
                }
            }
            if (pair == 2)
            {
                score = 2;
                highlight = new List<int>(temp);
            }
            return pair == 2 ? true : false;
        }

        public bool ThreeOfAKind()
        {
            for (int index = 0; index < _face.Count; index++)
            {
                if (_face[index].cards.Count == 3)
                {
                    score = 3;
                    foreach (var card in _face[index].cards)
                    {
                        highlight.Add(card);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool Stright()
        {
            List<int> temp = new List<int>();
            for (int index = 0; index < _face.Count - 1; index++)
            {
                if (_face[index].cards.Count == 1 && _face[index + 1].cards.Count == 1)
                {
                    temp.Add(_face[index].cards[0]);
                    if(temp.Count == _cards.Count - 1)
                    {
                        temp.Add(_face[index + 1].cards[0]);
                    }
                }
            }
            if (temp.Count == _cards.Count)
            {
                highlight = new List<int>(temp);
                score = 4;
            }
            return temp.Count == _cards.Count ? true : false;
        }

        public bool Flush()
        {
            if (allSuit(_spade) || allSuit(_ace) || allSuit(_heart) || allSuit(_diamond))
            {
                foreach (var card in _face)
                {
                    if(card.cards.Count > 0)
                    {
                        score = 5;
                        highlight.Add(card.cards[0]);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FullHouse()
        {
            if (Pair() && ThreeOfAKind())
            {
                score = 6;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FourOfAKind()
        {
            for (int index = 0; index < _face.Count; index++)
            {
                if (_face[index].cards.Count == 4)
                {
                    score = 7;
                    foreach (var card in _face[index].cards)
                    {
                        highlight.Add(card);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool StrightFlush()
        {
            if(Stright() && Flush())
            {
                score = 8;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
