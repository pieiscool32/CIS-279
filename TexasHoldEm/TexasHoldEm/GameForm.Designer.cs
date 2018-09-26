namespace TexasHoldEm
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flopOne = new System.Windows.Forms.PictureBox();
            this.river = new System.Windows.Forms.PictureBox();
            this.turn = new System.Windows.Forms.PictureBox();
            this.flopThree = new System.Windows.Forms.PictureBox();
            this.flopTwo = new System.Windows.Forms.PictureBox();
            this.cardTwo = new System.Windows.Forms.PictureBox();
            this.cardOne = new System.Windows.Forms.PictureBox();
            this.callButton = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.dealerInfo = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.dealerMoney = new System.Windows.Forms.Label();
            this.potMoney = new System.Windows.Forms.Label();
            this.gameInfo = new System.Windows.Forms.Label();
            this.fold = new System.Windows.Forms.Button();
            this.showDebug = new System.Windows.Forms.Button();
            this.shuffle = new System.Windows.Forms.Button();
            this.addPlayer = new System.Windows.Forms.Button();
            this.playerCount = new System.Windows.Forms.Label();
            this.removePlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flopOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.river)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOne)).BeginInit();
            this.SuspendLayout();
            // 
            // flopOne
            // 
            this.flopOne.Location = new System.Drawing.Point(40, 31);
            this.flopOne.Name = "flopOne";
            this.flopOne.Size = new System.Drawing.Size(72, 96);
            this.flopOne.TabIndex = 0;
            this.flopOne.TabStop = false;
            // 
            // river
            // 
            this.river.Location = new System.Drawing.Point(407, 31);
            this.river.Name = "river";
            this.river.Size = new System.Drawing.Size(72, 96);
            this.river.TabIndex = 1;
            this.river.TabStop = false;
            // 
            // turn
            // 
            this.turn.Location = new System.Drawing.Point(312, 31);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(72, 96);
            this.turn.TabIndex = 2;
            this.turn.TabStop = false;
            // 
            // flopThree
            // 
            this.flopThree.Location = new System.Drawing.Point(223, 31);
            this.flopThree.Name = "flopThree";
            this.flopThree.Size = new System.Drawing.Size(72, 96);
            this.flopThree.TabIndex = 3;
            this.flopThree.TabStop = false;
            // 
            // flopTwo
            // 
            this.flopTwo.Location = new System.Drawing.Point(135, 31);
            this.flopTwo.Name = "flopTwo";
            this.flopTwo.Size = new System.Drawing.Size(72, 96);
            this.flopTwo.TabIndex = 4;
            this.flopTwo.TabStop = false;
            // 
            // cardTwo
            // 
            this.cardTwo.Location = new System.Drawing.Point(223, 168);
            this.cardTwo.Name = "cardTwo";
            this.cardTwo.Size = new System.Drawing.Size(72, 96);
            this.cardTwo.TabIndex = 5;
            this.cardTwo.TabStop = false;
            // 
            // cardOne
            // 
            this.cardOne.Location = new System.Drawing.Point(135, 168);
            this.cardOne.Name = "cardOne";
            this.cardOne.Size = new System.Drawing.Size(72, 96);
            this.cardOne.TabIndex = 6;
            this.cardOne.TabStop = false;
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(407, 205);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(75, 23);
            this.callButton.TabIndex = 7;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(407, 170);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 8;
            this.betButton.Text = "string";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // dealerInfo
            // 
            this.dealerInfo.AutoSize = true;
            this.dealerInfo.Location = new System.Drawing.Point(312, 180);
            this.dealerInfo.Name = "dealerInfo";
            this.dealerInfo.Size = new System.Drawing.Size(32, 13);
            this.dealerInfo.TabIndex = 9;
            this.dealerInfo.Text = "string";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(407, 167);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 13);
            this.debug.TabIndex = 10;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(40, 240);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset Game";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // dealerMoney
            // 
            this.dealerMoney.AutoSize = true;
            this.dealerMoney.Location = new System.Drawing.Point(312, 236);
            this.dealerMoney.Name = "dealerMoney";
            this.dealerMoney.Size = new System.Drawing.Size(32, 13);
            this.dealerMoney.TabIndex = 12;
            this.dealerMoney.Text = "string";
            // 
            // potMoney
            // 
            this.potMoney.AutoSize = true;
            this.potMoney.Location = new System.Drawing.Point(312, 223);
            this.potMoney.Name = "potMoney";
            this.potMoney.Size = new System.Drawing.Size(32, 13);
            this.potMoney.TabIndex = 14;
            this.potMoney.Text = "string";
            // 
            // gameInfo
            // 
            this.gameInfo.AutoSize = true;
            this.gameInfo.Location = new System.Drawing.Point(312, 166);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(32, 13);
            this.gameInfo.TabIndex = 15;
            this.gameInfo.Text = "string";
            // 
            // fold
            // 
            this.fold.Location = new System.Drawing.Point(407, 239);
            this.fold.Name = "fold";
            this.fold.Size = new System.Drawing.Size(75, 23);
            this.fold.TabIndex = 16;
            this.fold.Text = "Fold";
            this.fold.UseVisualStyleBackColor = true;
            this.fold.Click += new System.EventHandler(this.fold_Click);
            // 
            // showDebug
            // 
            this.showDebug.Location = new System.Drawing.Point(40, 170);
            this.showDebug.Name = "showDebug";
            this.showDebug.Size = new System.Drawing.Size(75, 23);
            this.showDebug.TabIndex = 17;
            this.showDebug.Text = "Telemetry";
            this.showDebug.UseVisualStyleBackColor = true;
            this.showDebug.Click += new System.EventHandler(this.showDebug_Click);
            // 
            // shuffle
            // 
            this.shuffle.Location = new System.Drawing.Point(40, 205);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(75, 23);
            this.shuffle.TabIndex = 18;
            this.shuffle.Text = "Reshuffle";
            this.shuffle.UseVisualStyleBackColor = true;
            this.shuffle.Click += new System.EventHandler(this.shuffle_Click);
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(382, 205);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(19, 23);
            this.addPlayer.TabIndex = 19;
            this.addPlayer.Text = "+";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // playerCount
            // 
            this.playerCount.AutoSize = true;
            this.playerCount.Location = new System.Drawing.Point(312, 249);
            this.playerCount.Name = "playerCount";
            this.playerCount.Size = new System.Drawing.Size(32, 13);
            this.playerCount.TabIndex = 20;
            this.playerCount.Text = "string";
            // 
            // removePlayer
            // 
            this.removePlayer.Location = new System.Drawing.Point(382, 239);
            this.removePlayer.Name = "removePlayer";
            this.removePlayer.Size = new System.Drawing.Size(19, 23);
            this.removePlayer.TabIndex = 21;
            this.removePlayer.Text = "-";
            this.removePlayer.UseVisualStyleBackColor = true;
            this.removePlayer.Click += new System.EventHandler(this.removePlayer_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 294);
            this.Controls.Add(this.removePlayer);
            this.Controls.Add(this.playerCount);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.shuffle);
            this.Controls.Add(this.showDebug);
            this.Controls.Add(this.fold);
            this.Controls.Add(this.gameInfo);
            this.Controls.Add(this.potMoney);
            this.Controls.Add(this.dealerMoney);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.dealerInfo);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.cardOne);
            this.Controls.Add(this.cardTwo);
            this.Controls.Add(this.flopTwo);
            this.Controls.Add(this.flopThree);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.river);
            this.Controls.Add(this.flopOne);
            this.Name = "GameForm";
            this.Text = "Texas Hold Em";
            ((System.ComponentModel.ISupportInitialize)(this.flopOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.river)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flopOne;
        private System.Windows.Forms.PictureBox river;
        private System.Windows.Forms.PictureBox turn;
        private System.Windows.Forms.PictureBox flopThree;
        private System.Windows.Forms.PictureBox flopTwo;
        private System.Windows.Forms.PictureBox cardTwo;
        private System.Windows.Forms.PictureBox cardOne;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label dealerInfo;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label dealerMoney;
        private System.Windows.Forms.Label potMoney;
        private System.Windows.Forms.Button fold;
        private System.Windows.Forms.Button showDebug;
        private System.Windows.Forms.Button shuffle;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Label playerCount;
        protected System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.Button removePlayer;
    }
}

