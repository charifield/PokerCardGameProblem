namespace DeckOfCards_Solution
{
    partial class Game
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
            this.groupGame = new System.Windows.Forms.GroupBox();
            this.pnlGameScene = new System.Windows.Forms.Panel();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWithCards = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redistributeCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.simulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSimulatorUntilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu5 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu6 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu7 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu8 = new System.Windows.Forms.ToolStripMenuItem();
            this.simu9 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupGame.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupGame
            // 
            this.groupGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupGame.BackColor = System.Drawing.Color.White;
            this.groupGame.Controls.Add(this.pnlGameScene);
            this.groupGame.Location = new System.Drawing.Point(31, 122);
            this.groupGame.Name = "groupGame";
            this.groupGame.Size = new System.Drawing.Size(792, 553);
            this.groupGame.TabIndex = 0;
            this.groupGame.TabStop = false;
            this.groupGame.Text = "Game";
            // 
            // pnlGameScene
            // 
            this.pnlGameScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGameScene.Location = new System.Drawing.Point(3, 16);
            this.pnlGameScene.Name = "pnlGameScene";
            this.pnlGameScene.Size = new System.Drawing.Size(786, 534);
            this.pnlGameScene.TabIndex = 0;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(150, 82);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(120, 28);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Redistribute Cards";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnRedistribute_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(402, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to Field\'s Poker Game";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblWithCards);
            this.groupBox2.Controls.Add(this.lblRounds);
            this.groupBox2.Controls.Add(this.lblPlayers);
            this.groupBox2.Location = new System.Drawing.Point(528, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(155, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time: 0ms";
            // 
            // lblWithCards
            // 
            this.lblWithCards.AutoSize = true;
            this.lblWithCards.Location = new System.Drawing.Point(22, 49);
            this.lblWithCards.Name = "lblWithCards";
            this.lblWithCards.Size = new System.Drawing.Size(105, 13);
            this.lblWithCards.TabIndex = 2;
            this.lblWithCards.Text = "Players with Cards: 0";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(155, 27);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(56, 13);
            this.lblRounds.TabIndex = 1;
            this.lblRounds.Text = "Rounds: 0";
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(22, 27);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(80, 13);
            this.lblPlayers.TabIndex = 0;
            this.lblPlayers.Text = "Total Players: 0";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(276, 82);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 28);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(183, 17);
            this.toolStripStatusLabel1.Text = "Application written by Field Chari";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.simulatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.redistributeCardsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // redistributeCardsToolStripMenuItem
            // 
            this.redistributeCardsToolStripMenuItem.Name = "redistributeCardsToolStripMenuItem";
            this.redistributeCardsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.redistributeCardsToolStripMenuItem.Text = "Redistribute Cards";
            this.redistributeCardsToolStripMenuItem.Click += new System.EventHandler(this.btnRedistribute_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(152, 22);
            this.btnAbout.Text = "&About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // simulatorToolStripMenuItem
            // 
            this.simulatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSimulatorUntilToolStripMenuItem});
            this.simulatorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.simulatorToolStripMenuItem.Name = "simulatorToolStripMenuItem";
            this.simulatorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.simulatorToolStripMenuItem.Text = "Simulator";
            // 
            // runSimulatorUntilToolStripMenuItem
            // 
            this.runSimulatorUntilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simu1,
            this.simu2,
            this.simu3,
            this.simu4,
            this.simu5,
            this.simu6,
            this.simu7,
            this.simu8,
            this.simu9});
            this.runSimulatorUntilToolStripMenuItem.Name = "runSimulatorUntilToolStripMenuItem";
            this.runSimulatorUntilToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.runSimulatorUntilToolStripMenuItem.Text = "Run Simulator Until...";
            // 
            // simu1
            // 
            this.simu1.Name = "simu1";
            this.simu1.Size = new System.Drawing.Size(153, 22);
            this.simu1.Text = "Five of a kind";
            this.simu1.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu2
            // 
            this.simu2.Name = "simu2";
            this.simu2.Size = new System.Drawing.Size(153, 22);
            this.simu2.Text = "Straight Flush";
            this.simu2.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu3
            // 
            this.simu3.Name = "simu3";
            this.simu3.Size = new System.Drawing.Size(153, 22);
            this.simu3.Text = "Four of a kind";
            this.simu3.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu4
            // 
            this.simu4.Name = "simu4";
            this.simu4.Size = new System.Drawing.Size(153, 22);
            this.simu4.Text = "Full House";
            this.simu4.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu5
            // 
            this.simu5.Name = "simu5";
            this.simu5.Size = new System.Drawing.Size(153, 22);
            this.simu5.Text = "Flush";
            this.simu5.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu6
            // 
            this.simu6.Name = "simu6";
            this.simu6.Size = new System.Drawing.Size(153, 22);
            this.simu6.Text = "Straight";
            this.simu6.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu7
            // 
            this.simu7.Name = "simu7";
            this.simu7.Size = new System.Drawing.Size(153, 22);
            this.simu7.Text = "Three of a kind";
            this.simu7.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu8
            // 
            this.simu8.Name = "simu8";
            this.simu8.Size = new System.Drawing.Size(153, 22);
            this.simu8.Text = "Two Pair";
            this.simu8.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // simu9
            // 
            this.simu9.Name = "simu9";
            this.simu9.Size = new System.Drawing.Size(153, 22);
            this.simu9.Text = "One Pair";
            this.simu9.Click += new System.EventHandler(this.runSimulator_Click);
            // 
            // pbxLoading
            // 
            this.pbxLoading.Image = global::DeckOfCards_Solution.Properties.Resources.loading;
            this.pbxLoading.Location = new System.Drawing.Point(492, 46);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(30, 30);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLoading.TabIndex = 12;
            this.pbxLoading.TabStop = false;
            this.pbxLoading.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeckOfCards_Solution.Properties.Resources.freeImage;
            this.pictureBox1.Location = new System.Drawing.Point(34, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 700);
            this.Controls.Add(this.pbxLoading);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.groupGame);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(854, 690);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field\'s Poker Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupGame.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupGame;
        private System.Windows.Forms.Panel pnlGameScene;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblWithCards;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redistributeCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem simulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runSimulatorUntilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simu1;
        private System.Windows.Forms.ToolStripMenuItem simu2;
        private System.Windows.Forms.ToolStripMenuItem simu3;
        private System.Windows.Forms.ToolStripMenuItem simu4;
        private System.Windows.Forms.ToolStripMenuItem simu5;
        private System.Windows.Forms.ToolStripMenuItem simu6;
        private System.Windows.Forms.ToolStripMenuItem simu7;
        private System.Windows.Forms.ToolStripMenuItem simu8;
        private System.Windows.Forms.ToolStripMenuItem simu9;
        private System.Windows.Forms.PictureBox pbxLoading;
    }
}

