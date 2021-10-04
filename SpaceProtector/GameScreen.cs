using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceProtector
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move alien
            //TODO move spaceship

            //TODO colour objects
            //TODO sound effects

            //TODO when alien touches bottom of screen or spaceship end game - player loses
            //TODO when all aliens die end game - player wins
        }

        //TODO list to hold aliens

        //TODO track score
    }
}
