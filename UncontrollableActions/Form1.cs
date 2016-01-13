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
            game.OnTurnEnd += OnTurnEnd;

            //Subscribe to Actor events
            Actor.OnArousalChanged += OnArousalChanged;

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

        private void OnTurnEnd(int currentTurnIndex, Actor turnPlayer)
        {
            //Increase the current turn player's arousal by 1.
            turnPlayer.Arousal += 1;
        }

        private void OnArousalChanged(Actor actor, double oldVal, double newVal)
        {
            //Print this to the console.
            consoleTextBox.Text += "" + actor.Name + "'s arousal went from " + oldVal + " to " + newVal + "\n";
        }

        private void OnStimulusChanged(Actor actor, double oldVal, double newVal)
        {
            //Print this to the console.
            consoleTextBox.Text += "" + actor.Name + "'s stimulus went from " + oldVal + " to " + newVal + "\n";
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            game.NextTurn();
        }
    }
}
