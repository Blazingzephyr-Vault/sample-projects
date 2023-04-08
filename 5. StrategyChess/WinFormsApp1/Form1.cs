
using System;
using System.Windows.Forms;

namespace StrategyChess
{
    public partial class Form1 : Form
    {
        private Game _game;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameLoaded(object sender, EventArgs e)
        {
            _game = new Game(pictureBox1);
        }

        private void OnPieceSwitched(object sender, EventArgs e)
        {
            _game.OnPieceSwitched(comboBox1.SelectedIndex);
        }
    }
}