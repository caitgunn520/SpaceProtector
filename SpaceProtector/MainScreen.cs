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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // start new game
            Form f = this.FindForm();
            
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

            f.Controls.Remove(this);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // quit game
            Application.Exit();
        }
    }
}
