using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfCards_Solution
{
    public partial class Game : Form
    {
        public PlayerSelect playerSelect;

        public List<Model_Player> players = new List<Model_Player>();
        public List<Model_Card> deck = new List<Model_Card>();
        int rounds = 0;

        bool runningSimulation = false;

        public Game()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the game loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_Load(object sender, EventArgs e)
        {
            //Record Execution Time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Assign_Cards();
            DetermineWinners();
            DrawGameScene();

            stopwatch.Stop();
            if(!runningSimulation) lblTime.Text = "Elapsed: " + (Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds)).ToString() + " ms";
        }


        /// <summary>
        /// Assign Random Cards to Players
        /// </summary>
        private void Assign_Cards()
        {
            try
            {
                Random rnd = new Random();

                //Reset Marked Value
                foreach (Model_Card card in deck)
                    card.winnerMark = false;

                List<Model_Card> deckCopy = new List<Model_Card>(deck);

                foreach (Model_Player player in players)
                {
                    //Reset Player Stats
                    player.resetValues();

                    //Only assign cards if enough are left
                    if (deckCopy.Count > 5)
                    {
                        while (player.cards.Count < 5)
                        {
                            //Assign a random card to player
                            int r = rnd.Next(0, deckCopy.Count - 1);
                            player.cards.Add(deckCopy[r]);
                            player.totalCardsValue += deckCopy[r].value;
                            deckCopy.RemoveAt(r);
                        }

                        //Sort Assigned Cards according to value
                        player.cards.Sort((x, y) => -x.value.CompareTo(y.value));
                    }
                    else
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assign Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Rank winners based on cards held
        /// </summary>
        private void DetermineWinners()
        {
            try
            {
                foreach (Model_Player player in players)
                {
                    if (player.cards.Count < 5)
                        continue;

                    //Set Default Values
                    player.hand = "High Card";
                    player.points = 1;

                    //Full House Variables
                    bool fhPair = false; bool fhThree = false;

                    //Two Pair Variables
                    IEnumerable<Model_Card> firstPair = null; IEnumerable<Model_Card> secondPair = null;

                    //One Pair Variable

                    foreach (Model_Card card in player.cards)
                    {
                        //Five of a Kind  ###########################
                        var query1 = from p in player.cards
                                     where p.number == card.number
                                     orderby p.number descending
                                     select p;

                        if (query1.Count() == 4)
                        {
                            var wildCard = from p in player.cards
                                           where p.name == "JK"
                                           select p;
                            if (wildCard.Count() == 1)
                            {
                                player.points = 10;
                                player.hand = "Five of a Kind";
                                player.winState = Model_WinState.WinState.FiveOfAKind;
                                MarkWinners(player.cards, player);
                                break;
                            }
                        }



                        //Straight Flush  ###########################
                        var query2 = from p in player.cards
                                     where p.suit == card.suit
                                     orderby p.value descending
                                     select p;

                        if (query2.Count() == 5)
                        {
                            var sfPreviousValue = 0;
                            bool sfbust = false;
                            foreach (Model_Card myCard in query2)
                            {
                                if (sfPreviousValue != 0 && myCard.value != sfPreviousValue - 1)
                                {
                                    sfbust = true; break;
                                }
                                sfPreviousValue = myCard.value;
                            }
                            if (!sfbust)
                            {
                                player.points = 9;
                                player.hand = "Straight Flush";
                                player.winState = Model_WinState.WinState.StraightFlush;
                                MarkWinners(query2, player);
                                break;
                            }
                        }


                        //Four of a kind  ###########################
                        var query3 = from p in player.cards
                                     where p.number == card.number
                                     orderby p.number descending
                                     select p;

                        if (query3.Count() == 4)
                        {
                            player.points = 8;
                            player.hand = "Four of a kind";
                            player.winState = Model_WinState.WinState.FourOfAKind;
                            MarkWinners(query3, player);
                            break;
                        }



                        //Full House  ###########################
                        var query4 = from p in player.cards
                                     where p.number == card.number
                                     orderby p.number descending
                                     select p;

                        if (query4.Count() == 2)
                            fhPair = true;

                        if (query4.Count() == 3)
                            fhThree = true;

                        if (fhPair == true && fhThree == true)
                        {
                            player.points = 7;
                            player.hand = "Full House";
                            player.winState = Model_WinState.WinState.FullHouse;
                            MarkWinners(query4, player);
                            break;
                        }


                        //Flush  ###########################
                        var query5 = from p in player.cards
                                     where p.suit == card.suit
                                     select p;

                        if (query5.Count() == 5)
                        {
                            player.points = 6;
                            player.hand = "Flush";
                            player.winState = Model_WinState.WinState.Flush;
                            MarkWinners(query5, player);
                            break;
                        }


                        //Straight  ###########################
                        var sPreviousValue = 0;
                        bool sBust = false;
                        foreach (Model_Card myCard in player.cards)
                        {
                            if (sPreviousValue != 0 && myCard.value != sPreviousValue - 1)
                            {
                                sBust = true; break;
                            }
                            sPreviousValue = myCard.value;
                        }
                        if (!sBust)
                        {
                            player.points = 5;
                            player.hand = "Straight";
                            player.winState = Model_WinState.WinState.Straight;
                            MarkWinners(player.cards, player);
                            break;
                        }


                        //Three of a kind  ###########################
                        var query6 = from p in player.cards
                                     where p.number == card.number
                                     orderby p.number descending
                                     select p;

                        if (query6.Count() == 3)
                        {
                            player.points = 4;
                            player.hand = "Three of a kind";
                            player.winState = Model_WinState.WinState.ThreeOfAKind;
                            MarkWinners(query6, player);
                            break;
                        }


                        //Two Pair  ###########################
                        var query7 = from p in player.cards
                                     where p.number == card.number
                                     orderby p.number descending
                                     select p;

                        if (query7.Count() == 2)
                        {
                            if (firstPair == null)
                            {
                                firstPair = query7;
                                continue;
                            }
                            if (secondPair == null)
                            {
                                bool equal = isEqual(firstPair, query7);
                                if (!equal)
                                    secondPair = query7;

                            }
                        }
                        if (firstPair != null && secondPair != null)
                        {
                            player.points = 3;
                            player.hand = "Two Pair";
                            player.winState = Model_WinState.WinState.TwoPair;
                            MarkWinners(firstPair, player); MarkWinners(secondPair, player);
                            break;
                        }


                        //One Pair  ###########################
                        var query8 = from p in player.cards
                                     where p.number == card.number
                                     orderby p.number descending
                                     select p;

                        if (query8.Count() == 2 || (card == player.cards.Last() && firstPair != null))
                        {
                            player.points = 2;
                            player.hand = "One Pair";
                            player.winState = Model_WinState.WinState.OnePair;
                            if (query8.Count() == 2)
                                MarkWinners(query8, player);
                            else
                                MarkWinners(firstPair, player);
                            break;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        /// <summary>
        /// Draw players and decks
        /// </summary>
        private void DrawGameScene()
        {
            try
            {
                rounds++;

                if (runningSimulation) return;

                lblPlayers.Text = "Total Players: " + players.Count;
                lblRounds.Text = "Round: " + rounds;
                pnlGameScene.Controls.Clear();
                pnlGameScene.AutoScroll = true;
                pnlGameScene.HorizontalScroll.Visible = false;


                int count = 0;

                //Sort Points and Value
                var orderedPlayers = from p in players
                                     orderby p.points descending, p.winningCardsValue descending, p.totalCardsValue descending
                                     select p;

                foreach (Model_Player player in orderedPlayers)
                {
                    //Only show players with cards
                    if (player.cards.Count > 0)
                    {
                        var playerScene = new Game_Player();
                        playerScene.lblPlayer.Text = player.playerName;
                        playerScene.Left = 10;
                        playerScene.Top = count * playerScene.Height;
                        playerScene.lblPosition.Text = (count + 1).ToString();
                        playerScene.lblHand.Text = player.hand;

                        int index = 0;

                        //Place Cards
                        foreach (Model_Card card in player.cards)
                        {
                            ((PictureBox)playerScene.Controls["card" + (index + 1)]).BackgroundImage = player.cards[index].image;
                            ((Panel)playerScene.Controls["pnlCard" + (index + 1)]).Visible = player.cards[index].winnerMark;
                            index++;
                        }

                        //Show crown on first place with a high score
                        if (count == 0 && player.points > 2)
                        {
                            playerScene.imgCrown.Left = playerScene.lblPosition.Left; playerScene.imgCrown.Top = playerScene.lblPosition.Top;
                            playerScene.imgCrown.Visible = true;
                        }

                        pnlGameScene.Controls.Add(playerScene);
                        count++;
                    }

                    lblWithCards.Text = "Players with Cards: " + count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Scene Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //########################## HHELPER METHOD ##########################



        /// <summary>
        /// Compare two iEnumerables
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private bool isEqual(IEnumerable<Model_Card> first, IEnumerable<Model_Card> second)
        {
            int matches = 0;
            foreach(var card in first)
            {
                foreach (var card2 in second)
                {
                    if (card == card2)
                        matches++;
                }
            }

            if (matches >= 2)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Mark winning cards as winners
        /// </summary>
        /// <param name="cards"></param>
        private void MarkWinners(IEnumerable<Model_Card> cards, Model_Player player)
        {
            foreach (Model_Card card in cards)
            {
                card.winnerMark = true;
                player.winningCards.Add(card);
                player.winningCardsValue += card.value;
            }

        }





        //########################## BUTTON PRESSES ##########################




        /// <summary>
        /// Shuffle cards and restart game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedistribute_Click(object sender, EventArgs e)
        {
            Game_Load(null, null);
        }


        /// <summary>
        /// Pick New Players and restart Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// End the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Return to Player Select when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
            playerSelect.Location = this.Location;
            playerSelect.Show();
        }

        /// <summary>
        /// Display About Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }




        //########################## SIMULATION ##########################



        /// <summary>
        /// Run Simulator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void runSimulator_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            runningSimulation = true;
            int modeIndex = Convert.ToInt32(((ToolStripMenuItem)sender).Name.Substring((((ToolStripMenuItem)sender).Name.Length - 1)));
            Model_WinState.WinState mode = (Model_WinState.WinState)modeIndex;

            bool simulationSuccessful = false;

            btnShuffle.Enabled = false; menuStrip1.Enabled = false;
            pnlGameScene.Controls.Clear();
            pbxLoading.Location = new System.Drawing.Point(groupGame.Width / 2, groupGame.Height / 2);
            pbxLoading.BringToFront(); pbxLoading.Show();

            //Run Task Asyncronously
            await Task.Run(() =>
            {
                int maxAttempt = 50000;
                while (maxAttempt >= 1)
                {
                    Game_Load(null, null);
                    foreach (Model_Player player in players)
                    {
                        if (player.winState == mode)
                        {
                            simulationSuccessful = true;
                            break;
                        }

                    }
                    if (simulationSuccessful)
                        break;

                    maxAttempt -= 1;
                }

            });
            
            if (!simulationSuccessful)
                MessageBox.Show("Simulation Failed. Tried 50000 simulations without a match. The odds are against you", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            pbxLoading.Hide();
            btnShuffle.Enabled = true; menuStrip1.Enabled = true;
            runningSimulation = false;
            this.Refresh();
            DrawGameScene();
            this.Cursor = Cursors.Default;
        }
    }
}
