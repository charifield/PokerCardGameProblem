using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using DeckOfCards_Solution.Interfaces;

namespace DeckOfCards_Solution
{
    public class Model_Card: ICard
    {
        //Stores the file name of the card
        public string name { get; set; }

        //Stores what suit the card is
        public string suit { get; set; }

        //Stores what number the card is 'K,Q,J,10,9...A
        public string number { get; set; }

        //Stores the image of the card
        public Image image { get; set; }

        //Stores the numeric value of the card
        public int value { get; set; }

        //Indicates if the card is a Joker
        public bool isJoker { get; set; }

        //Indicates if the card is part of a winning hand
        public bool winnerMark { get; set; }


        /// <summary>
        /// Load Card Image into Model
        /// </summary>
        public Model_Card(string Name, string Suit)
        {
            this.name = Name;
            this.suit = Suit;

            //If Joker
            if (Name == "JK")
            {
                isJoker = true;
                value = 0;
            }

            //Get Face Value
            else if (name.Length == 2 && isJoker == false)
            {
                number = name[0].ToString();
            }
            else if (name.Length == 3 && isJoker == false)
            {
                number = name.Substring(0, 2);
            }

            //Assign Numeric Value to Card
            switch (number)
            {
                case "A":
                    value = 14;
                    break;
                case "K":
                    value = 13;
                    break;
                case "Q":
                    value = 12;
                    break;
                case "J":
                    value = 11;
                    break;
                default:
                    if(number != "" && number != null)
                        value = Convert.ToInt32(number);
                    break;
            }

            loadImage();
        }


        /// <summary>
        /// Load Image of Card from File
        /// </summary>
        private void loadImage()
        {
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Cards\");
            foreach (string file in files)
            {
                if (file.Contains(name))
                {
                    string path = file;
                    this.image = Image.FromFile(path);
                    break;
                }
            }
        }
    }
}
