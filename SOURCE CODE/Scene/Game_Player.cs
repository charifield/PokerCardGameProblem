using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace DeckOfCards_Solution
{
    public partial class Game_Player : UserControl
    {
        public Game_Player()
        {
            InitializeComponent();
        }

        private void Game_Player_Load(object sender, EventArgs e)
        {
            //Animate Cards
            foreach (Control c in this.Controls)
            {
                if(c is PictureBox || c is Panel)
                {
                    Transition.run(c, "Left", card1.Left, c.Left, new TransitionType_Deceleration(200));
                }
                
            }
        }
    }
}
