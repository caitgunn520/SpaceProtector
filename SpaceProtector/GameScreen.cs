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
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        int score;

        SpaceShip spaceShip;

        bool leftDown;
        bool rightDown;
        bool spaceDown;

        // list to hold aliens
        List<Alien> alienList = new List<Alien>();

        // list to hold bullets
        List<Bullet> bulletList = new List<Bullet>();
        
        private void GameScreen_Load(object sender, EventArgs e)
        {
            // create spaceship
            spaceShip = new SpaceShip(this.Width / 2, 350, 30, 15, 10);

            // create aliens
            for (int i = 0; i < 10; i++)
            {
                Alien alien = new Alien(i * 40 + 20, 20, 20, 10);
                alienList.Add(alien);
            }

            // set booleans to false
            leftDown = false;
            rightDown = false;
            spaceDown = false;

            // turn on the game timer
            gameTimer.Enabled = true;

            // set score to zero
            score = 0;
        }
        
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }
        
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }
        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move alien
            // move spaceship if left or right button is being pressed
            if (leftDown)
            {
                spaceShip.x -= spaceShip.speed;
            }
            if (rightDown)
            {
                spaceShip.x += spaceShip.speed;
            }
            
            // make ship shoot bullets if spacebar is pressed
            if (spaceDown)
            {
                Bullet bullet = new Bullet(5, 30, spaceShip.x + (spaceShip.width / 2), spaceShip.y - (spaceShip.length / 2));
                bulletList.Add(bullet);
            }

            // make bullets move
            foreach (Bullet bullet in bulletList)
            {
                bullet.y -= bullet.speed;
                
                // delete offscreen bullets
                if (bullet.y < 0)
                {
                    bulletList.Remove(bullet);
                }
            }

            //TODO sound effects

            //TODO when alien touches bottom of screen or spaceship end game - player loses
            //TODO when all aliens die end game - player wins
            Refresh();
        }

        //TODO track score

        public void BulletsAliensCollision()
        {
            // index values of all bullets that collide with an alien
            List<int> bulletsToRemove = new List<int>();

            // index values of all aliens that collide with a bullet
            List<int> aliensToRemove = new List<int>();

            foreach (Bullet b in bulletList)
            {
                foreach (Alien a in alienList)
                {
                    // uses collision method in alien class and returns true
                    // if alien "a" has collided with bullet "b"
                    if 
                }
            }
        }

        // graphics
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, spaceShip.x, spaceShip.y, spaceShip.width, spaceShip.length);

            foreach (Alien alien in alienList)
            {
                e.Graphics.FillRectangle(redBrush, alien.x, alien.y, alien.size, alien.size);
            }

            foreach (Bullet bullet in bulletList)
            {
                e.Graphics.FillRectangle(blackBrush, bullet.x, bullet.y, bullet.size, bullet.size);
            }
        }
    }
}
