using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UncontrollableActions
{
    public partial class Form1 : Form
    {
        private Game game = new Game();

        public Form1()
        {
            InitializeComponent();
        }


        //Events

        private void Form1_Load(object sender, EventArgs e)
        {
            //Subscribe to game events.
            game.OnGameStart += OnGameStart;
            game.OnTurnStart += OnTurnStart;

            //Create the actors in the game.
            new Actor("Rosalina", game);
            new Actor("Peach", game);
            new Actor("Samus", game);

            game.StartGame();
        }

        private void OnGameStart()
        {
            //Add all of the players to the listbox
            for (int i = 0; i < game.PlayerCount; i++)
            {
                playerListBox.Items.Add(game.GetPlayer(i).Name);
            }
        }

        private void OnTurnStart(int currentTurnIndex, Actor turnPlayer)
        {
            //Change the label.
            currentTurnLabel.Text = "It is currently " + turnPlayer.Name + "'s turn.";
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            game.NextTurn();
        }
    }
}
