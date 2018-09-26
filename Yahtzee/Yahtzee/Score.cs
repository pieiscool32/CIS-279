using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Score: Dice
    {
        public int[] score = new int[13];
        public int total;
        public bool[] keep = new bool[13];

        public Score()
        {
            
        }

        private int diceSum(Dice dice)
        {
            int count = 0;
            for(int a = 0; a < dice.die.Count; a++)
            {
                count += dice.die[a];
            }
            return count;
        }

        private bool isThree(Dice dice)
        {
            List<int> count = new List<int>() { 0, 0, 0, 0, 0, 0 };
            for(int a = 0; a < dice.die.Count; a++)
            {
                count[dice.die[a] - 1] += 1;
            }
            if (count.Contains(3))
            {
                return true;
            }
            return false;
        }

        private bool isFour(Dice dice)
        {
            List<int> count = new List<int>() { 0, 0, 0, 0, 0, 0 };
            for (int a = 0; a < dice.die.Count; a++)
            {
                count[dice.die[a] - 1] += 1;
            }
            if (count.Contains(4))
            {
                return true;
            }
            return false;
        }

        private bool isFull(Dice dice)
        {
            List<int> count = new List<int>() { 0, 0, 0, 0, 0, 0 };
            for (int a = 0; a < dice.die.Count; a++)
            {
                count[dice.die[a] - 1] += 1;
            }
            if(count.Contains(2) && count.Contains(3))
            {
                return true;
            }
            return false;
        }

        private bool isSmall(Dice dice)
        {
            if(dice.die.Contains(3) && dice.die.Contains(4) 
                && ((dice.die.Contains(1) && dice.die.Contains(2))
                || (dice.die.Contains(2) && dice.die.Contains(5))
                || (dice.die.Contains(5) && dice.die.Contains(6))))
            {
                return true;
            }
            return false;
        }

        private bool isLarge(Dice dice)
        {
            if(dice.die.Contains(2) && dice.die.Contains(3)
                && dice.die.Contains(4) && dice.die.Contains(5)
                && (dice.die.Contains(1) || dice.die.Contains(6)))
            {
                return true;
            }
            return false;
        }

        public bool isYahtzee(Dice dice)
        {
            if(dice.die[0] == dice.die[1] && dice.die[1] == dice.die[2]
                && dice.die[2] == dice.die[3] && dice.die[3] == dice.die[4])
            {
                return true;
            }
            return false;
        }

        public void calculate(Dice dice)
        {
            for(int a=0; a<score.Length; a++)
            {
                if (!keep[a])
                {
                    score[a] = 0;
                }
            }

            for(int a=0; a<dice.die.Count; a++)
            {
                if (!keep[dice.die[a]-1])
                {
                    score[dice.die[a] - 1] += dice.die[a];
                }
            }

            if (isThree(dice))
            {
                score[6] = diceSum(dice);
            }
            if (isFour(dice))
            {
                score[7] = diceSum(dice);
            }
            if (isFull(dice))
            {
                score[8] = 25;
            }
            if (isSmall(dice))
            {
                score[9] = 30;
            }
            if (isLarge(dice))
            {
                score[10] = 40;
            }
            score[11] = diceSum(dice);
            if (isYahtzee(dice))
            {
                score[12] = 50;
            }

            total = 0;
            for(int a=0; a<score.Length; a++)
            {
                if (keep[a])
                {
                    total += score[a];
                }
            }
        }
    }
}
