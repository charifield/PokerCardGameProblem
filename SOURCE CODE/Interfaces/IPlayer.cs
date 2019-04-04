using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards_Solution.Interfaces
{
    interface IPlayer
    {
        string playerName { get; set; }
        string hand { get; set; }
        int points { get; set; }
        int totalCardsValue { get; set; }
        Model_WinState.WinState winState { get; set; }
    }
}
