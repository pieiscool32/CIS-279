using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexasHoldEm.Properties;

namespace TexasHoldEm
{
    public partial class GameForm : Form
    {
        private const int delay = 800;
        private const int bet = 20;
        private const int startMoney = 500;
        private const int maxPlayers = 7;
        private const double betFold = 0.4;
        private const double callFold = 0.51;

        public DebugForm debugWindow;
        public List<DebugContainer> container;
        public PokerRound round;
        public List<Image> cards;
        public List<PictureBox> table;
        public int pot;
        public bool busy; //system is busy
        public bool autopilot; //system is on autopilot

        public GameForm()
        {
            InitializeComponent();
            table = new List<PictureBox>
            {
                flopOne, flopTwo, flopThree, turn, river
            };
            Clean(true);
            cards = new List<Image>() {
                Resources.card1, Resources.card2, Resources.card3, Resources.card4, Resources.card5, Resources.card6,
                Resources.card7, Resources.card8, Resources.card9, Resources.card10, Resources.card11, Resources.card12,
                Resources.card13, Resources.card14, Resources.card15, Resources.card16, Resources.card17, Resources.card18,
                Resources.card19, Resources.card20, Resources.card21, Resources.card22, Resources.card23, Resources.card24,
                Resources.card25, Resources.card26, Resources.card27, Resources.card28, Resources.card29, Resources.card30,
                Resources.card31, Resources.card32, Resources.card33, Resources.card34, Resources.card35, Resources.card36,
                Resources.card37, Resources.card38, Resources.card39, Resources.card40, Resources.card41, Resources.card42,
                Resources.card43, Resources.card44, Resources.card45, Resources.card46, Resources.card47, Resources.card48,
                Resources.card49, Resources.card50, Resources.card51, Resources.card52 };

        }

        private void Clean(bool all)
        {
            if (all)
            {
                RandomGen rand = new RandomGen();
                round = new PokerRound(rand, 2);
                round.Done();
                round.money.Add(startMoney);
                round.money.Add(startMoney);
                pot = 0;
                foreach (var card in table)
                {
                    card.Image = null;
                }
                cardOne.Image = null;
                cardTwo.Image = null;

                dealerInfo.Visible = false;
                debug.Visible = false;
                potMoney.Visible = false;
                playerCount.Visible = false;
                betButton.Text = $"Bet ${bet}";
                busy = false;
                autopilot = false;
            }
            else
            {
                turn.Image = null;
                river.Image = null;
                potMoney.Visible = true;
            }
            foreach (var card in table)
            {
                setBorder(card, BorderStyle.None);
            }
            setBorder(cardOne, BorderStyle.None);
            setBorder(cardTwo, BorderStyle.None);
            dealerMoney.Text = $"Bank: ${round.money[0]}";
            gameInfo.Text = all ? "Welcome" : gameInfo.Text;
        }

        delegate void SetBorderCallback(PictureBox location, BorderStyle style);
        //to make calls threadsafe
        public void setBorder(PictureBox location, BorderStyle style)
        {
            if (location.InvokeRequired)
            {
                SetBorderCallback call = new SetBorderCallback(setBorder);
                this.Invoke(call, new object[] { location, style });
            }
            else
            {
                location.BorderStyle = style;
            }
        }

        delegate void SetImageCallback(PictureBox location, Image pic);
        //to make calls threadsafe
        public void setImage(PictureBox location, Image pic)
        {
            if (location.InvokeRequired)
            {
                SetImageCallback call = new SetImageCallback(setImage);
                this.Invoke(call, new object[] { location, pic });
            }
            else
            {
                location.Image = pic;
            }
        }

        delegate void SetTextCallback(Label location, string text);
        //to make calls threadsafe
        public void setInfo(Label location, string text)
        {
            if (location.InvokeRequired)
            {
                SetTextCallback call = new SetTextCallback(setInfo);
                this.Invoke(call, new object[] { location, text });
            }
            else
            {
                location.Text = text;
            }
        }

        private void showMessage(string message)
        {
            Debug.WriteLine($"Showing Message: {message}");
            string temp = gameInfo.Text;
            setInfo(gameInfo, message);
            Task.Delay(delay).ContinueWith(t => setInfo(gameInfo, temp));
        }

        private void updateTelemetry()
        {
            //wraper to set telemetry
            for (int index = 0; index < round.numPlayers; index++)
            {
                if (debugWindow != null) Window.SetTelemetry(this, index);
            }
        }

        private void placeBet(int value, int index)
        {
            pot += value;
            round.money[index] -= value;
            setInfo(potMoney, $"Pot: ${pot}");
            if (index == 0) setInfo(dealerMoney, $"Bank: ${round.money[index]}");
        }

        private void payWinner(List<int> winnrs)
        {
            Debug.WriteLine($"Pot ${pot}");
            foreach(var winner in winnrs)
            {
                if (winner == 0 && winnrs.Count == 1) //'dealer' is always 0
                {
                    setInfo(gameInfo, "Dealer Wins");
                    Debug.WriteLine("Dealer Wins");
                }
                else if (winnrs.Count == 1)
                {
                    setInfo(gameInfo, $"Computer{winner} Wins");
                    Debug.WriteLine($"Computer{winner} Wins");
                }
                else
                {
                    Debug.WriteLine($"Player{winner} Wins {pot / winnrs.Count}");
                }
                round.money[winner] += pot / winnrs.Count;
            }

            if(winnrs.Count != 1)
            {
                setInfo(gameInfo, "Split Pot");
                Debug.WriteLine("Split Pot");
            }

            pot = 0;
            setInfo(potMoney, $"Pot: ${pot}");
            setInfo(dealerMoney, $"Bank: ${round.money[0]}");
            round.Done();
            updateTelemetry();

            busy = false;
            if(autopilot) Debug.WriteLine("Autopilot Disabled");
            autopilot = false;
        }

        private bool changeBorder(int index)
        {
            foreach(var card in round.player[0].highlight)
            {
                if(index == card)
                {
                    return true;
                }
            }
            return false;
        }

        private void updateTable()
        {
            //refersh the cards on the table
            for (int index = 0; index < round.table.Count; index++)
            {
                setImage(table[index], cards[round.table[index] - 1]);
                if (changeBorder(round.table[index])) setBorder(table[index], BorderStyle.Fixed3D);
                else setBorder(table[index], BorderStyle.None);
            }
            setImage(cardOne, cards[round.playerHand[0].handCards[0] - 1]);
            if (changeBorder(round.playerHand[0].handCards[0])) setBorder(cardOne, BorderStyle.Fixed3D);
            else setBorder(cardOne, BorderStyle.None);
            setImage(cardTwo, cards[round.playerHand[0].handCards[1] - 1]);
            if (changeBorder(round.playerHand[0].handCards[1])) setBorder(cardTwo, BorderStyle.Fixed3D);
            else setBorder(cardTwo, BorderStyle.None);
        }

        private void Bet(int index)
        {
            //Used by the bots only
            Debug.WriteLine($"Computer{index} has {round.player[index].bestScore} @ {round.player[index].winOdds * 100}%");
            //If the odds of winning are above the threshold
            if (round.player[index].winOdds >= betFold)
            {
                setInfo(gameInfo, $"Computer{index} Raises");
                Debug.WriteLine($"Computer{index} Raises ${bet}");
                placeBet(bet, index);
            }
            else
            {
               setInfo(gameInfo, $"Computer{index} Folds");
                Debug.WriteLine($"Computer{index} Folds");
                round.player[index].canPlay = false;
            }
            if (!Wager.canPlay(round, autopilot))
            {
                Task.Delay(delay).ContinueWith(t => payWinner(Wager.winner(round)));
            }
            else if (Wager.IsLast(round, index))
            {
                busy = false;
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if(Wager.bankrupt(round))
            {
                showMessage("Insufficient Funds");
            }
            else if (round.turn > 0)
            {
                showMessage("Finish Round First");
            }
            else if (busy)
            {
                showMessage("Please Wait");
            }
            else if (round.deck.Count < 5 + 2 * round.numPlayers)
            {
                showMessage("Insufficient Cards");
            }
            else
            {
                //cleans up the board
                Clean(false);
                setInfo(gameInfo, $"Dealer Bets ${bet}");
                Debug.WriteLine($"Dealer Bets ${bet}");

                //everyone makes an inital bet and can play
                for(int index = 0; index < round.numPlayers; index++)
                {
                    placeBet(bet, index);
                    round.player[index].canPlay = true;
                }

                dealerInfo.Visible = true;
                potMoney.Visible = true;

                round.Bet(); //does a betting round
                if (debugWindow != null) updateTelemetry();
                setInfo(dealerInfo, $"Win Odds: {round.player[0].winOdds * 100}%\n{round.player[0].handType}\nCards: {round.deck.Count}");

                updateTable();

                busy = true; //the system is now busy
                int num = 1; //used to keep track of delays
                foreach (var player in round.player)
                {
                    if (player.canPlay && player.index > 0)
                    {
                        Task.Delay(num * delay).ContinueWith(t => Bet(player.index));
                        num++;
                    }
                }
            }
        }

        private void doCall()
        {
            updateTable();
            updateTelemetry();
            int num = 1; //used to keep track of delays
            foreach (var player in round.player)
            {
                if (player.canPlay && player.index > 0)
                {
                    Task.Delay(num * delay).ContinueWith(t => Call(player.index));
                    num++;
                }
            }
        }

        private void Call(int index)
        {
            //Used by the bots only
            if (round.player[index].canPlay)
            {
                Debug.WriteLine($"Computer{index} has {round.player[index].bestScore} @ {round.player[index].winOdds * 100}%");
                //If the odds of winning are above the threshold
                if (round.player[index].winOdds >= callFold)
                {
                    setInfo(gameInfo, $"Computer{index} Raises");
                    Debug.WriteLine($"Computer{index} Raises ${bet}");
                    placeBet(bet, index);
                }
                else
                {
                    setInfo(gameInfo, $"Computer{index} Folds");
                    Debug.WriteLine($"Computer{index} Folds");
                    round.player[index].canPlay = false;
                    if (!Wager.canPlay(round, autopilot) && autopilot)
                    {
                        Task.Delay(delay).ContinueWith(t => payWinner(new List<int>() { index }));
                    }
                }
            }
            bool last = Wager.IsLast(round, index);
            if (!Wager.canPlay(round, autopilot) && !autopilot)
            {
                Task.Delay(delay).ContinueWith(t => payWinner(Wager.winner(round)));
            }
            else if (round.turn == 3 && last)
            {
                Task.Delay(delay).ContinueWith(t => payWinner(Wager.winner(round)));
            }
            else if (autopilot && last)
            {
                if (Wager.canPlay(round, autopilot))
                {
                    round.player[index].canPlay = false;
                    if (!Wager.canPlay(round, autopilot))
                    {
                        Task.Delay(delay).ContinueWith(t => payWinner(new List<int>() { index }));
                    }
                    else
                    {
                        round.player[index].canPlay = true;
                        Debug.WriteLine("Autopilot Advances");
                        round.Call();
                        updateTable();
                        updateTelemetry();
                        setInfo(gameInfo, "River Revealed");
                        Debug.WriteLine("River Revealed");
                        Task.Delay(delay).ContinueWith(t => doCall());
                    }
                }
            }
            else if (last)
            {
                busy = false;
            }
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            if (Wager.bankrupt(round))
            {
                showMessage("Insufficient Funds");
            }
            else if (busy)
            {
                showMessage("Please Wait");
            }
            else if (round.playerHand == null)
            {
                showMessage("Place Bet First");
            }
            else
            {
                setInfo(gameInfo, "Dealer Calls");
                Debug.WriteLine("Dealer Calls");
                placeBet(bet, 0); //dealer is always 0

                round.Call();
                setInfo(dealerInfo, $"Win Odds: {round.player[0].winOdds * 100}%\n{round.player[0].handType}\nCards: {round.deck.Count}");
                busy = true; //the system is now busy
                doCall();
            }
        }

        private void fold_Click(object sender, EventArgs e)
        {
            //if the round is over
            if(round.playerHand == null)
            {
                showMessage("Place Bet First");
            }
            else if (busy)
            {
                showMessage("Please Wait");
            }
            else
            {
                setInfo(gameInfo, "Player Folds");
                Debug.WriteLine("Player Folds");
                setInfo(dealerInfo, null);
                round.player[0].canPlay = false;
                busy = true;
                autopilot = true;
                Debug.WriteLine("Autopilot Enabled");
                round.Call();
                updateTable();
                updateTelemetry();
                if(round.turn == 2) setInfo(gameInfo, "Turn Revealed");
                if(round.turn == 3) setInfo(gameInfo, "River Revealed");
                doCall();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Clean(true);
        }

        private void showDebug_Click(object sender, EventArgs e)
        {
            debugWindow = new DebugForm();
            debugWindow.Size = new Size(190, 280);
            container = new List<DebugContainer>();
            foreach (var player in round.player)
            {
                //window ia already the size of 1
                if(player.index != 0) Window.resize(debugWindow);
                container.Add(new DebugContainer());
                int x = (player.index * 190);

                for (int index = 0; index < 6; index++)
                {
                    int y = 110 + ((index + 1) * 18);
                    container[player.index].right.Add(Window.makeLabel(debugWindow, x + 12, y));
                    container[player.index].left.Add(Window.makeLabel(debugWindow, x + 90, y));
                }
                container[player.index].cards.Add(Window.makePicture(debugWindow, x + 12, 12));
                container[player.index].cards.Add(Window.makePicture(debugWindow, x + 90, 12));
            }
            debugWindow.Show();
        }

        private void shuffle_Click(object sender, EventArgs e)
        {
            if (busy)
            {
                showMessage("Please Wait");
            }
            else if (round.playerHand != null)
            {
                showMessage("Finish Round First");
            }
            else
            {
                RandomGen rand = new RandomGen();
                round.Shuffle(rand);
                showMessage("Cards Shuffled");
            }
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            if (round.playerHand != null)
            {
                showMessage("Finish Round First");
            }
            else if (round.numPlayers >= maxPlayers)
            {
                showMessage("Max Players");
                    
            }
            else
            {
                showMessage("Computer Added");
                Debug.WriteLine("Computer Added");
                round.AddPlayer();
                round.money.Add(startMoney);
                playerCount.Visible = true;
                setInfo(playerCount, $"{round.numPlayers} Players");
            }
        }

        private void removePlayer_Click(object sender, EventArgs e)
        {
            if (round.playerHand != null)
            {
                showMessage("Finish Round First");
            }
            else if (round.numPlayers <= 2)
            {
                showMessage("Min Players");
            }
            else
            {
                showMessage("Comp Removed");
                Debug.WriteLine("Computer Removed");
                round.deletePlayer();
                setInfo(playerCount, $"{round.numPlayers} Players");
            }
        }
    }
}
