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
        
        SolidBrush blueBrush = new SolidBrush(Color.Blue);

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO create spaceship
            SpaceShip spaceShip = new SpaceShip(this.Width / 2, 400, 10, 20, 30);
        }
        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move alien
            //TODO move spaceship

            //TODO sound effects

            //TODO when alien touches bottom of screen or spaceship end game - player loses
            //TODO when all aliens die end game - player wins
        }

        //TODO list to hold aliens
        List<Alien> alienList = new List<Alien>();

        //TODO track score

        //TODO graphics
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, )
        }
    }
}
