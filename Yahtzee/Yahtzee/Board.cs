using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Properties;

namespace Yahtzee
{
    public partial class MainBoard : Form
    {
        Dice board;
        Score count;

        public MainBoard()
        {
            InitializeComponent();
            board = new Dice();
            count = new Score();
        }

        private void showScore()
        {
            count.calculate(board);
            for (int a = 0; a < count.score.Length; a++)
            {
                if (!count.keep[a])
                {
                    editScore(a + 1, 'c', 0);
                }
                if (count.score[a] != 0 && !count.keep[a])
                {
                    editScore(a + 1, 'e', count.score[a]);
                }
            }
            if (count.total > 0)
            {
                total.Text = count.total.ToString();
                total.Visible = true;
            }
        }

        private void hideScore()
        {
            for (int a = 0; a < count.score.Length; a++)
            {
                if (!count.keep[a])
                {
                    editScore(a + 1, 'c', 0);
                }
            }
        }

        private Image getImage(int die)
        {
            switch (die)
            {
                case 1:
                    return Resources.dice1;
                    break;
                case 2:
                    return Resources.dice2;
                    break;
                case 3:
                    return Resources.dice3;
                    break;
                case 4:
                    return Resources.dice4;
                    break;
                case 5:
                    return Resources.dice5;
                    break;
                case 6:
                    return Resources.dice6;
                    break;
                default:
                    return null;

            }
        }

        private void setDie(int die, int num)
        {
            switch (die)
            {
                case 1:
                    dieOne.Image = getImage(num);
                    break;
                case 2:
                    dieTwo.Image = getImage(num);
                    break;
                case 3:
                    dieThree.Image = getImage(num);
                    break;
                case 4:
                    dieFour.Image = getImage(num);
                    break;
                case 5:
                    dieFive.Image = getImage(num);
                    break;
            }
        }

        public void hideDice()
        {
            dieOne.Image = null;
            dieTwo.Image = null;
            dieThree.Image = null;
            dieFour.Image = null;
            dieFive.Image = null;
        }

        private void editScore(int pos, char type, int val)
        {
            switch (pos)
            {
                case 1:
                    switch (type)
                    {
                        case 's':
                            score1.Enabled = false;
                            score1.Visible = true;
                            score1.Text = val.ToString();
                            break;
                        case 'e':
                            score1.Enabled = true;
                            score1.Visible = true;
                            score1.Text = val.ToString();
                            break;
                        case 'c':
                            score1.Enabled = false;
                            score1.Visible = false;
                            score1.Text = "Score";
                            break;
                    }
                    break;
                case 2:
                    switch (type)
                    {
                        case 's':
                            score2.Enabled = false;
                            score2.Visible = true;
                            score2.Text = val.ToString();
                            break;
                        case 'e':
                            score2.Enabled = true;
                            score2.Visible = true;
                            score2.Text = val.ToString();
                            break;
                        case 'c':
                            score2.Enabled = false;
                            score2.Visible = false;
                            score2.Text = "Score";
                            break;
                    }
                    break;
                case 3:
                    switch (type)
                    {
                        case 's':
                            score3.Enabled = false;
                            score3.Visible = true;
                            score3.Text = val.ToString();
                            break;
                        case 'e':
                            score3.Enabled = true;
                            score3.Visible = true;
                            score3.Text = val.ToString();
                            break;
                        case 'c':
                            score3.Enabled = false;
                            score3.Visible = false;
                            score3.Text = "Score";
                            break;
                    }
                    break;
                case 4:
                    switch (type)
                    {
                        case 's':
                            score4.Enabled = false;
                            score4.Visible = true;
                            score4.Text = val.ToString();
                            break;
                        case 'e':
                            score4.Enabled = true;
                            score4.Visible = true;
                            score4.Text = val.ToString();
                            break;
                        case 'c':
                            score4.Enabled = false;
                            score4.Visible = false;
                            score4.Text = "Score";
                            break;
                    }
                    break;
                case 5:
                    switch (type)
                    {
                        case 's':
                            score5.Enabled = false;
                            score5.Visible = true;
                            score5.Text = val.ToString();
                            break;
                        case 'e':
                            score5.Enabled = true;
                            score5.Visible = true;
                            score5.Text = val.ToString();
                            break;
                        case 'c':
                            score5.Enabled = false;
                            score5.Visible = false;
                            score5.Text = "Score";
                            break;
                    }
                    break;
                case 6:
                    switch (type)
                    {
                        case 's':
                            score6.Enabled = false;
                            score6.Visible = true;
                            score6.Text = val.ToString();
                            break;
                        case 'e':
                            score6.Enabled = true;
                            score6.Visible = true;
                            score6.Text = val.ToString();
                            break;
                        case 'c':
                            score6.Enabled = false;
                            score6.Visible = false;
                            score6.Text = "Score";
                            break;
                    }
                    break;
                case 7:
                    switch (type)
                    {
                        case 's':
                            score7.Enabled = false;
                            score7.Visible = true;
                            score7.Text = val.ToString();
                            break;
                        case 'e':
                            score7.Enabled = true;
                            score7.Visible = true;
                            score7.Text = val.ToString();
                            break;
                        case 'c':
                            score7.Enabled = false;
                            score7.Visible = false;
                            score7.Text = "Score";
                            break;
                    }
                    break;
                case 8:
                    switch (type)
                    {
                        case 's':
                            score8.Enabled = false;
                            score8.Visible = true;
                            score8.Text = val.ToString();
                            break;
                        case 'e':
                            score8.Enabled = true;
                            score8.Visible = true;
                            score8.Text = val.ToString();
                            break;
                        case 'c':
                            score8.Enabled = false;
                            score8.Visible = false;
                            score8.Text = "Score";
                            break;
                    }
                    break;
                case 9:
                    switch (type)
                    {
                        case 's':
                            score9.Enabled = false;
                            score9.Visible = true;
                            score9.Text = val.ToString();
                            break;
                        case 'e':
                            score9.Enabled = true;
                            score9.Visible = true;
                            score9.Text = val.ToString();
                            break;
                        case 'c':
                            score9.Enabled = false;
                            score9.Visible = false;
                            score9.Text = "Score";
                            break;
                    }
                    break;
                case 10:
                    switch (type)
                    {
                        case 's':
                            score10.Enabled = false;
                            score10.Visible = true;
                            score10.Text = val.ToString();
                            break;
                        case 'e':
                            score10.Enabled = true;
                            score10.Visible = true;
                            score10.Text = val.ToString();
                            break;
                        case 'c':
                            score10.Enabled = false;
                            score10.Visible = false;
                            score10.Text = "Score";
                            break;
                    }
                    break;
                case 11:
                    switch (type)
                    {
                        case 's':
                            score11.Enabled = false;
                            score11.Visible = true;
                            score11.Text = val.ToString();
                            break;
                        case 'e':
                            score11.Enabled = true;
                            score11.Visible = true;
                            score11.Text = val.ToString();
                            break;
                        case 'c':
                            score11.Enabled = false;
                            score11.Visible = false;
                            score11.Text = "Score";
                            break;
                    }
                    break;
                case 12:
                    switch (type)
                    {
                        case 's':
                            score12.Enabled = false;
                            score12.Visible = true;
                            score12.Text = val.ToString();
                            break;
                        case 'e':
                            score12.Enabled = true;
                            score12.Visible = true;
                            score12.Text = val.ToString();
                            break;
                        case 'c':
                            score12.Enabled = false;
                            score12.Visible = false;
                            score12.Text = "Score";
                            break;
                    }
                    break;
                case 13:
                    switch (type)
                    {
                        case 's':
                            score13.Enabled = false;
                            score13.Visible = true;
                            score13.Text = val.ToString();
                            break;
                        case 'e':
                            score13.Enabled = true;
                            score13.Visible = true;
                            score13.Text = val.ToString();
                            break;
                        case 'c':
                            score13.Enabled = false;
                            score13.Visible = false;
                            score13.Text = "Score";
                            break;
                    }
                    break;
            }
        }

        private void saveOne_Click(object sender, EventArgs e)
        {
            if(turnNumber.Value != 0 && turnNumber.Value != 3)
            {
                if (board.saved[0])
                {
                    board.saved[0] = false;
                    saveOne.Text = "Save";
                }
                else
                {
                    board.saved[0] = true;
                    saveOne.Text = "Unsave";
                }
            }
        }

        private void saveTwo_Click(object sender, EventArgs e)
        {
            if(turnNumber.Value != 0 && turnNumber.Value != 3)
            {
                if (board.saved[1])
                {
                    board.saved[1] = false;
                    saveTwo.Text = "Save";
                }
                else
                {
                    board.saved[1] = true;
                    saveTwo.Text = "Unsave";
                }
            }
        }

        private void saveThree_Click(object sender, EventArgs e)
        {
            if(turnNumber.Value != 0 && turnNumber.Value != 3)
            {
                if (board.saved[2])
                {
                    board.saved[2] = false;
                    saveThree.Text = "Save";
                }
                else
                {
                    board.saved[2] = true;
                    saveThree.Text = "Unsave";
                }
            }
        }

        private void saveFour_Click(object sender, EventArgs e)
        {
            if(turnNumber.Value != 0 && turnNumber.Value != 3)
            {
                if (board.saved[3])
                {
                    board.saved[3] = false;
                    saveFour.Text = "Save";
                }
                else
                {
                    board.saved[3] = true;
                    saveFour.Text = "Unsave";
                }
            }
        }

        private void saveFive_Click(object sender, EventArgs e)
        {
            if(turnNumber.Value != 0 && turnNumber.Value != 3)
            {
                if (board.saved[4])
                {
                    board.saved[4] = false;
                    saveFive.Text = "Save";
                }
                else
                {
                    board.saved[4] = true;
                    saveFive.Text = "Unsave";
                }
            }
        }

        private void unsaveDice()
        {
            if (board.saved[0])
            {
                board.saved[0] = false;
                saveOne.Text = "Save";
            }
            if (board.saved[1])
            {
                board.saved[1] = false;
                saveTwo.Text = "Save";
            }
            if (board.saved[2])
            {
                board.saved[2] = false;
                saveThree.Text = "Save";
            }
            if (board.saved[3])
            {
                board.saved[3] = false;
                saveFour.Text = "Save";
            }
            if (board.saved[4])
            {
                board.saved[4] = false;
                saveFive.Text = "Save";
            }
        }

        private void endTurn()
        {
            turnNumber.Value = 0;
            this.showScore();
            this.hideScore();
            this.unsaveDice();
            this.hideDice();
        }

        private bool gameOver()
        {
            if(turnNumber.Value == 0)
            {
                return false;
            }
            if(score1.Enabled || score2.Enabled || score3.Enabled
                || score4.Enabled || score5.Enabled || score6.Enabled
                || score7.Enabled || score8.Enabled || score9.Enabled
                || score10.Enabled || score11.Enabled || score12.Enabled
                || score13.Enabled)
            {
                return false;
            }
            return true;
        }

        private void score1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(1, 's', count.score[0]);
            count.keep[0] = true;
            this.endTurn();
        }

        private void score2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(2, 's', count.score[1]);
            count.keep[1] = true;
            this.endTurn();
        }

        private void score3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(3, 's', count.score[2]);
            count.keep[2] = true;
            this.endTurn();
        }

        private void score4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(4, 's', count.score[3]);
            count.keep[3] = true;
            this.endTurn();
        }

        private void score5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(5, 's', count.score[4]);
            count.keep[4] = true;
            this.endTurn();
        }

        private void score6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(6, 's', count.score[5]);
            count.keep[5] = true;
            this.endTurn();
        }

        private void score7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(7, 's', count.score[6]);
            count.keep[6] = true;
            this.endTurn();
        }

        private void score8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(8, 's', count.score[7]);
            count.keep[7] = true;
            this.endTurn();
        }

        private void score9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(9, 's', count.score[8]);
            count.keep[8] = true;
            this.endTurn();
        }

        private void score10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(10, 's', count.score[9]);
            count.keep[9] = true;
            this.endTurn();
        }

        private void score11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(11, 's', count.score[10]);
            count.keep[10] = true;
            this.endTurn();
        }

        private void score12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(12, 's', count.score[11]);
            count.keep[11] = true;
            this.endTurn();
        }

        private void score13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editScore(13, 's', count.score[12]);
            count.keep[12] = true;
            this.endTurn();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            if (gameOver() && turnNumber.Value >= 3)
            {
                board = new Dice();
                count = new Score();
                this.hideScore();
                this.hideDice();
                this.unsaveDice();
                total.Text = "Total";
                total.Visible = false;
                turnNumber.Value = 0;
                rollButton.Text = "Roll Dice";
            }
            else
            {
                if (turnNumber.Value < 3)
                {
                    Random rand = new Random();
                    for (int a = 0; a < board.die.Count; a++)
                    {
                        if (!board.saved[a])
                        {
                            board.die[a] = rand.Next(1, 7);
                            setDie(a + 1, board.die[a]);
                        }
                    }
                    turnNumber.Value++;
                    this.showScore();

                }
                if (gameOver() && turnNumber.Value >= 3)
                {
                    rollButton.Text = "New Game";
                }
            }
        }
    }
}
