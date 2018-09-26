using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldEm
{
    class Wager
    {
        public static bool bankrupt(PokerRound round)
        {
            foreach (var bank in round.money)
            {
                if (bank <= 0) return true;
            }
            return false;
        }

        public static bool canPlay(PokerRound round, bool autopilot)
        {
            int count = 0;
            foreach (var player in round.player)
            {
                if (!player.canPlay) count++;
            }
            int modifier = autopilot ? 0 : 1;
            return count == round.numPlayers - modifier ? false : true;
        }

        public static bool IsLast(PokerRound round, int index)
        {
            int go = 0;
            foreach (var player in round.player)
            {
                if (player.canPlay && player.index > index) go++;
            }
            return go == 0 ? true : false;
        }

        public static List<int> winner(PokerRound round)
        {
            List<int> winnr = new List<int>();
            int score = 0;
            for (int index = 0; index < round.numPlayers; index++)
            {
                if (round.player[index].bestScore > score && round.player[index].canPlay)
                {
                    score = round.player[index].bestScore;
                }
            }

            foreach(var player in round.player)
            {
                if(player.bestScore == score && player.canPlay)
                {
                    winnr.Add(player.index);
                }
            }

            return winnr;
        }
    }
}
