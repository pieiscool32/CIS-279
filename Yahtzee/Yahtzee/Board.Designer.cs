namespace Yahtzee
{
    partial class MainBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.dieOne = new System.Windows.Forms.PictureBox();
            this.dieFive = new System.Windows.Forms.PictureBox();
            this.dieFour = new System.Windows.Forms.PictureBox();
            this.dieThree = new System.Windows.Forms.PictureBox();
            this.dieTwo = new System.Windows.Forms.PictureBox();
            this.saveOne = new System.Windows.Forms.Button();
            this.saveFive = new System.Windows.Forms.Button();
            this.saveFour = new System.Windows.Forms.Button();
            this.saveThree = new System.Windows.Forms.Button();
            this.saveTwo = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.turnNumber = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.LinkLabel();
            this.score2 = new System.Windows.Forms.LinkLabel();
            this.score1 = new System.Windows.Forms.LinkLabel();
            this.score13 = new System.Windows.Forms.LinkLabel();
            this.score11 = new System.Windows.Forms.LinkLabel();
            this.score12 = new System.Windows.Forms.LinkLabel();
            this.score10 = new System.Windows.Forms.LinkLabel();
            this.score8 = new System.Windows.Forms.LinkLabel();
            this.score9 = new System.Windows.Forms.LinkLabel();
            this.score7 = new System.Windows.Forms.LinkLabel();
            this.score6 = new System.Windows.Forms.LinkLabel();
            this.score5 = new System.Windows.Forms.LinkLabel();
            this.score4 = new System.Windows.Forms.LinkLabel();
            this.total = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dieOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieTwo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dieOne
            // 
            this.dieOne.Location = new System.Drawing.Point(22, 24);
            this.dieOne.Name = "dieOne";
            this.dieOne.Size = new System.Drawing.Size(55, 50);
            this.dieOne.TabIndex = 0;
            this.dieOne.TabStop = false;
            // 
            // dieFive
            // 
            this.dieFive.Location = new System.Drawing.Point(360, 24);
            this.dieFive.Name = "dieFive";
            this.dieFive.Size = new System.Drawing.Size(55, 50);
            this.dieFive.TabIndex = 1;
            this.dieFive.TabStop = false;
            // 
            // dieFour
            // 
            this.dieFour.Location = new System.Drawing.Point(278, 24);
            this.dieFour.Name = "dieFour";
            this.dieFour.Size = new System.Drawing.Size(55, 50);
            this.dieFour.TabIndex = 2;
            this.dieFour.TabStop = false;
            // 
            // dieThree
            // 
            this.dieThree.Location = new System.Drawing.Point(191, 24);
            this.dieThree.Name = "dieThree";
            this.dieThree.Size = new System.Drawing.Size(55, 50);
            this.dieThree.TabIndex = 3;
            this.dieThree.TabStop = false;
            // 
            // dieTwo
            // 
            this.dieTwo.Location = new System.Drawing.Point(105, 24);
            this.dieTwo.Name = "dieTwo";
            this.dieTwo.Size = new System.Drawing.Size(55, 50);
            this.dieTwo.TabIndex = 4;
            this.dieTwo.TabStop = false;
            // 
            // saveOne
            // 
            this.saveOne.Location = new System.Drawing.Point(22, 80);
            this.saveOne.Name = "saveOne";
            this.saveOne.Size = new System.Drawing.Size(55, 23);
            this.saveOne.TabIndex = 5;
            this.saveOne.Text = "Save";
            this.saveOne.UseVisualStyleBackColor = true;
            this.saveOne.Click += new System.EventHandler(this.saveOne_Click);
            // 
            // saveFive
            // 
            this.saveFive.Location = new System.Drawing.Point(360, 80);
            this.saveFive.Name = "saveFive";
            this.saveFive.Size = new System.Drawing.Size(55, 23);
            this.saveFive.TabIndex = 6;
            this.saveFive.Text = "Save";
            this.saveFive.UseVisualStyleBackColor = true;
            this.saveFive.Click += new System.EventHandler(this.saveFive_Click);
            // 
            // saveFour
            // 
            this.saveFour.Location = new System.Drawing.Point(278, 80);
            this.saveFour.Name = "saveFour";
            this.saveFour.Size = new System.Drawing.Size(55, 23);
            this.saveFour.TabIndex = 7;
            this.saveFour.Text = "Save";
            this.saveFour.UseVisualStyleBackColor = true;
            this.saveFour.Click += new System.EventHandler(this.saveFour_Click);
            // 
            // saveThree
            // 
            this.saveThree.Location = new System.Drawing.Point(191, 80);
            this.saveThree.Name = "saveThree";
            this.saveThree.Size = new System.Drawing.Size(55, 23);
            this.saveThree.TabIndex = 8;
            this.saveThree.Text = "Save";
            this.saveThree.UseVisualStyleBackColor = true;
            this.saveThree.Click += new System.EventHandler(this.saveThree_Click);
            // 
            // saveTwo
            // 
            this.saveTwo.Location = new System.Drawing.Point(105, 80);
            this.saveTwo.Name = "saveTwo";
            this.saveTwo.Size = new System.Drawing.Size(55, 23);
            this.saveTwo.TabIndex = 9;
            this.saveTwo.Text = "Save";
            this.saveTwo.UseVisualStyleBackColor = true;
            this.saveTwo.Click += new System.EventHandler(this.saveTwo_Click);
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(105, 144);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(228, 39);
            this.rollButton.TabIndex = 10;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // turnNumber
            // 
            this.turnNumber.Location = new System.Drawing.Point(105, 128);
            this.turnNumber.Maximum = 3;
            this.turnNumber.Name = "turnNumber";
            this.turnNumber.Size = new System.Drawing.Size(228, 10);
            this.turnNumber.Step = 1;
            this.turnNumber.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.score3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.score2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.score1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.score13, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.score11, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.score12, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.score10, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.score8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.score9, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.score7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.score6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.score5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.score4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.total, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(453, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(142, 292);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Yahtzee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Chance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Large Straight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Small Stright";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Full House";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Four of a Kind";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Three of a Kind";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sixes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fives";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Threes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Twos";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Location = new System.Drawing.Point(100, 40);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(35, 13);
            this.score3.TabIndex = 5;
            this.score3.TabStop = true;
            this.score3.Text = "Score";
            this.score3.Visible = false;
            this.score3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score3_LinkClicked);
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Location = new System.Drawing.Point(100, 20);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(35, 13);
            this.score2.TabIndex = 3;
            this.score2.TabStop = true;
            this.score2.Text = "Score";
            this.score2.Visible = false;
            this.score2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score2_LinkClicked);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Location = new System.Drawing.Point(100, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(35, 13);
            this.score1.TabIndex = 0;
            this.score1.TabStop = true;
            this.score1.Text = "Score";
            this.score1.Visible = false;
            this.score1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score1_LinkClicked);
            // 
            // score13
            // 
            this.score13.AutoSize = true;
            this.score13.Location = new System.Drawing.Point(100, 240);
            this.score13.Name = "score13";
            this.score13.Size = new System.Drawing.Size(35, 13);
            this.score13.TabIndex = 12;
            this.score13.TabStop = true;
            this.score13.Text = "Score";
            this.score13.Visible = false;
            this.score13.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score13_LinkClicked);
            // 
            // score11
            // 
            this.score11.AutoSize = true;
            this.score11.Location = new System.Drawing.Point(100, 200);
            this.score11.Name = "score11";
            this.score11.Size = new System.Drawing.Size(35, 13);
            this.score11.TabIndex = 10;
            this.score11.TabStop = true;
            this.score11.Text = "Score";
            this.score11.Visible = false;
            this.score11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score11_LinkClicked);
            // 
            // score12
            // 
            this.score12.AutoSize = true;
            this.score12.Location = new System.Drawing.Point(100, 220);
            this.score12.Name = "score12";
            this.score12.Size = new System.Drawing.Size(35, 13);
            this.score12.TabIndex = 11;
            this.score12.TabStop = true;
            this.score12.Text = "Score";
            this.score12.Visible = false;
            this.score12.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score12_LinkClicked);
            // 
            // score10
            // 
            this.score10.AutoSize = true;
            this.score10.Location = new System.Drawing.Point(100, 180);
            this.score10.Name = "score10";
            this.score10.Size = new System.Drawing.Size(35, 13);
            this.score10.TabIndex = 8;
            this.score10.TabStop = true;
            this.score10.Text = "Score";
            this.score10.Visible = false;
            this.score10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score10_LinkClicked);
            // 
            // score8
            // 
            this.score8.AutoSize = true;
            this.score8.Location = new System.Drawing.Point(100, 140);
            this.score8.Name = "score8";
            this.score8.Size = new System.Drawing.Size(35, 13);
            this.score8.TabIndex = 9;
            this.score8.TabStop = true;
            this.score8.Text = "Score";
            this.score8.Visible = false;
            this.score8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score8_LinkClicked);
            // 
            // score9
            // 
            this.score9.AutoSize = true;
            this.score9.Location = new System.Drawing.Point(100, 160);
            this.score9.Name = "score9";
            this.score9.Size = new System.Drawing.Size(35, 13);
            this.score9.TabIndex = 6;
            this.score9.TabStop = true;
            this.score9.Text = "Score";
            this.score9.Visible = false;
            this.score9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score9_LinkClicked);
            // 
            // score7
            // 
            this.score7.AutoSize = true;
            this.score7.Location = new System.Drawing.Point(100, 120);
            this.score7.Name = "score7";
            this.score7.Size = new System.Drawing.Size(35, 13);
            this.score7.TabIndex = 7;
            this.score7.TabStop = true;
            this.score7.Text = "Score";
            this.score7.Visible = false;
            this.score7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score7_LinkClicked);
            // 
            // score6
            // 
            this.score6.AutoSize = true;
            this.score6.Location = new System.Drawing.Point(100, 100);
            this.score6.Name = "score6";
            this.score6.Size = new System.Drawing.Size(35, 13);
            this.score6.TabIndex = 4;
            this.score6.TabStop = true;
            this.score6.Text = "Score";
            this.score6.Visible = false;
            this.score6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score6_LinkClicked);
            // 
            // score5
            // 
            this.score5.AutoSize = true;
            this.score5.Location = new System.Drawing.Point(100, 80);
            this.score5.Name = "score5";
            this.score5.Size = new System.Drawing.Size(35, 13);
            this.score5.TabIndex = 2;
            this.score5.TabStop = true;
            this.score5.Text = "Score";
            this.score5.Visible = false;
            this.score5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score5_LinkClicked);
            // 
            // score4
            // 
            this.score4.AutoSize = true;
            this.score4.Location = new System.Drawing.Point(100, 60);
            this.score4.Name = "score4";
            this.score4.Size = new System.Drawing.Size(35, 13);
            this.score4.TabIndex = 1;
            this.score4.TabStop = true;
            this.score4.Text = "Score";
            this.score4.Visible = false;
            this.score4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.score4_LinkClicked);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(100, 260);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 13;
            this.total.TabStop = true;
            this.total.Text = "Total";
            this.total.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ones";
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.turnNumber);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.saveTwo);
            this.Controls.Add(this.saveThree);
            this.Controls.Add(this.saveFour);
            this.Controls.Add(this.saveFive);
            this.Controls.Add(this.saveOne);
            this.Controls.Add(this.dieTwo);
            this.Controls.Add(this.dieThree);
            this.Controls.Add(this.dieFour);
            this.Controls.Add(this.dieFive);
            this.Controls.Add(this.dieOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainBoard";
            this.Text = "Yahtzee";
            ((System.ComponentModel.ISupportInitialize)(this.dieOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieTwo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dieOne;
        private System.Windows.Forms.PictureBox dieFive;
        private System.Windows.Forms.PictureBox dieFour;
        private System.Windows.Forms.PictureBox dieThree;
        private System.Windows.Forms.PictureBox dieTwo;
        private System.Windows.Forms.Button saveFive;
        private System.Windows.Forms.Button saveFour;
        private System.Windows.Forms.Button saveThree;
        private System.Windows.Forms.Button saveTwo;
        private System.Windows.Forms.Button saveOne;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.ProgressBar turnNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel score1;
        private System.Windows.Forms.LinkLabel score3;
        private System.Windows.Forms.LinkLabel score2;
        private System.Windows.Forms.LinkLabel score13;
        private System.Windows.Forms.LinkLabel score11;
        private System.Windows.Forms.LinkLabel score12;
        private System.Windows.Forms.LinkLabel score10;
        private System.Windows.Forms.LinkLabel score8;
        private System.Windows.Forms.LinkLabel score9;
        private System.Windows.Forms.LinkLabel score7;
        private System.Windows.Forms.LinkLabel score6;
        private System.Windows.Forms.LinkLabel score5;
        private System.Windows.Forms.LinkLabel score4;
        private System.Windows.Forms.LinkLabel total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

