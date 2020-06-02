using System;
using System.Windows.Forms;

namespace BlackJack
{
    partial class StartForm : Form
    {
        // Main constructor for StartForm
        public StartForm()
        {
            InitializeComponent();
        }

        //Start a new game
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            // Show the main BlackJack UI game
            using (BlackJackForm blackjackform = new BlackJackForm())
            {
                Hide();
                blackjackform.ShowDialog();
                Show();
            }
        }

        //Go to option form to select player
        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            // Show the Options panel
            using (OptionsForm optionsForm = new OptionsForm())
            {
                Hide();
                optionsForm.ShowDialog();
                Show();
            }
        }

        // Exits the application
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exit the Game
            Application.Exit();
        }
    }
}