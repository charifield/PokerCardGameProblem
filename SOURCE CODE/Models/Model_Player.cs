using DeckOfCards_Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards_Solution
{
    public class Model_Player: IPlayer
    {
        //Stores the name of the Player
        public string playerName { get; set; }

        //Stores what hand they have been dealt
        public string hand { get; set; }

        //Stores what win state they achieved
        public Model_WinState.WinState winState { get; set; }

        //Stores points awarded for hand
        public int points { get; set; }

        //Stores total value of all cards
        public int totalCardsValue { get; set; }
        public int winningCardsValue { get; set; }

        //Stores all the cards they have been dealt
        public List<Model_Card> cards = new List<Model_Card>();
        public List<Model_Card> winningCards = new List<Model_Card>();

        public Model_Player(string name)
        {
            this.playerName = name;
        }


        /// <summary>
        /// Reset of variables relating to a player
        /// </summary>
        public void resetValues()
        {
            cards = new List<Model_Card>();
            winningCards = new List<Model_Card>();

            winState = Model_WinState.WinState.Default;
            points = 0;
            totalCardsValue = 0;
            winningCardsValue = 0;
        }
    }
}
