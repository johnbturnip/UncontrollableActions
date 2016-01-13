using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncontrollableActions
{
    public class Game
    {
        //Public properties
        public Actor CurrentTurnPlayer { get { return playerList[currentTurnIndex]; } }
        public int CurrentTurnIndex { get { return currentTurnIndex; } }
        
        public int PlayerCount { get { return playerList.Count; } }

        //Events
        public delegate void ParameterlessEvent();
        public delegate void TurnEvent(int playerIndex, Actor turnPlayer);

        public event ParameterlessEvent OnGameStart;

        public event TurnEvent OnTurnEnd;
        public event TurnEvent OnTurnStart;

        //Private fields
        private bool started = false;

        private List<Actor> playerList = new List<Actor>();
        private int currentTurnIndex = 0;


        //Interface methods

        public Actor GetPlayer(int i)
        {
            //Returns the ith player, starting at 0.
            return playerList[i];
        }
        
        public void AddPlayer(Actor actor)
        {
            if (!playerList.Contains(actor))
            {
                playerList.Add(actor);
            }
        }

        public void StartGame()
        {
            //Starts the game.
            started = true;
            currentTurnIndex = 0;

            //Send the OnGameStart event
            if (OnGameStart != null)
            {
                OnGameStart();
            }

            //Send the OnTurnStart event
            if (OnTurnStart != null)
            {
                OnTurnStart(currentTurnIndex, CurrentTurnPlayer);
            }
        }

        public void NextTurn()
        {
            //Abort if the game isn't started.
            if (!started)
            {
                return;
            }

            //Fire the OnTurnEnd event
            if (OnTurnEnd != null)
            {
                OnTurnEnd(currentTurnIndex, CurrentTurnPlayer);
            }

            //Move to the next player's turn
            currentTurnIndex++;
            currentTurnIndex %= playerList.Count;

            //Fire the OnTurnStart event
            if (OnTurnStart != null)
            {
                OnTurnStart(currentTurnIndex, CurrentTurnPlayer);
            }
        }
    }
}
