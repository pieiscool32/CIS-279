using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    public class PokerRound
    {
        private PokerDeck _deck;

        public int turn { get; private set; }
        public int numPlayers { get; private set; }
        public Stack<int> deck { get; private set; }
        public List<OtherHand> player { get; private set; }
        public List<PokerHand> playerHand { get; private set; }
        public List<int> money { get; set; }
        public List<int> table { get; private set; }

        public PokerRound(INumberGenerator _generator, int _players)
        {
            turn = 0;
            money = new List<int>();
            Shuffle(_generator); //shuffle new deck
            numPlayers = _players;
            player = new List<OtherHand>(); //set players
            for (int index = 0; index < numPlayers; index++)
            {
                if(index == 0) //the 'dealer' is always first
                {
                    player.Add(new OtherHand("Dealer", index));
                } else
                {
                    player.Add(new OtherHand($"Computer{index}", index));
                }
            }
        }

        public void AddPlayer()
        {
            numPlayers++;
            player.Add(new OtherHand($"Computer{numPlayers - 1}", numPlayers - 1));
        }

        public void deletePlayer()
        {
            if (playerHand != null) playerHand.RemoveAt(numPlayers - 1);
            player.RemoveAt(numPlayers-1);
            numPlayers--;
        }

        public void Shuffle(INumberGenerator _generator)
        {
            _deck = new PokerDeck(_generator);
            deck = new Stack<int>();
            foreach (var card in _deck.cards)
            {
                deck.Push(card);
            }
        }

        public List<int> Deal(int num)
        {
            List<int> ret = new List<int>();
            for (int count = 0; count < num; count++)
            {
                ret.Add(deck.Pop()); //take cards off the deck
            }
            return ret;
        }

        public List<int> Join(List<int> origin, List<int> add)
        {
            List<int> ret = new List<int>(origin);
            for (int count = 0; count < add.Count; count++)
            {
                ret.Add(add[count]); 
            }
            return ret;
        }

        public void Bet()
        {
            turn = 1;
            table = Deal(3);
            playerHand = new List<PokerHand>(); //reset all player's hands

            for(int index = 0; index < numPlayers; index++)
            {
                playerHand.Add(new PokerHand(Deal(2))); //add two cards
            }

            foreach(var hand in playerHand)
            {
                foreach(var otherPlayer in playerHand)
                {
                    if(hand != otherPlayer)
                    {
                        //put cards not in the player's hand in other player's hands
                        otherPlayer.addHand(hand.handCards);
                    }
                }
            }

            for(int index = 0; index < numPlayers; index++)
            {
                //give it a deck, table, and the player's cards
                player[index].FindOdds(Join(new List<int>(deck), playerHand[index].otherCards), table, playerHand[index].handCards);
            }
        }

        public void Call()
        {
            table = Join(table, Deal(1)); //deal another card to the table
            for (int index = 0; index < numPlayers; index++)
            {
                //give it a deck, table, and the player's cards
                player[index].FindOdds(Join(new List<int>(deck), playerHand[index].otherCards), table, playerHand[index].handCards);
            }

            turn++;
        }

        public void Done()
        {
            //the current round is over
            turn = 0;
            playerHand = null;
        }
    }
}
