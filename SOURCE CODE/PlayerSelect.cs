using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DeckOfCards_Solution
{
    public partial class PlayerSelect : Form
    {
        public PlayerSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Browse for Player File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Open File Select Dialog
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select List of Players";
            openFile.DefaultExt = "txt";
            openFile.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFile.Filter = "txt files (*.txt)|*.txt";
            openFile.RestoreDirectory = true;
            openFile.CheckFileExists = true;
            openFile.ShowDialog();

            //After File is selected
            if (openFile.FileName != "")
            {
                txtFile.Text = openFile.FileName;
                btnStart.Enabled = true;
            }
        }

        /// <summary>
        /// Start the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //If file exists, Parse File
            if(File.Exists(txtFile.Text))
            {
                List<Model_Card> cards = parseListOfCards();
                List<Model_Player> players = parseListOfPlayers(txtFile.Text);

                if (players != null && cards != null && players.Count > 0 && cards.Count > 0)
                {
                    MessageBox.Show(string.Format("{0} players found, {1} cards. Starting game.", players.Count.ToString(), cards.Count.ToString()), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Game game = new Game();
                    game.playerSelect = this;
                    game.deck = cards;
                    game.players = players;
                    game.Show();
                }
                else
                {
                    MessageBox.Show("Could not load player / cards files. Please try again", "Error Parsing Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnStart.Enabled = false;
            }
        }


        /// <summary>
        /// Look through file and extract players
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private List<Model_Player> parseListOfPlayers(string filePath)
        {
            try
            {
                int counter = 0;
                string line;
                List<Model_Player> players = new List<Model_Player>();
                System.IO.StreamReader file = new System.IO.StreamReader(filePath);

                while ((line = file.ReadLine()) != null)
                {
                    if (line == "") continue;
                    players.Add(new Model_Player(line));
                    System.Console.WriteLine(line);
                    counter++;
                }

                file.Close();
                

                if (players.Count > 0)
                    return players;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Parse through all available cards
        /// </summary>
        /// <returns></returns>
        private List<Model_Card> parseListOfCards()
        {
            try
            {
                int counter = 0;
                string line;
                List<Model_Card> cards = new List<Model_Card>();

                System.IO.StreamReader file = new System.IO.StreamReader("Cards\\cards.txt");

                while ((line = file.ReadLine()) != null)
                {
                    if (!chkDeck.Checked)
                        if (line == "JK") continue;

                    cards.Add(new Model_Card(line, line.Substring(line.Length - 1, 1)));
                    System.Console.WriteLine(line);
                    counter++;
                }

                file.Close();

                if (cards.Count > 0)
                    return cards;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; ;
            }
        }
    }
}
