using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards_Solution.Interfaces
{
    interface ICard
    {
        string name { get; set; }
        string suit { get; set; }
        string number { get; set; }
        Image image { get; set; }
        int value { get; set; }
        bool isJoker { get; set; }
        bool winnerMark { get; set; }
    }
}
