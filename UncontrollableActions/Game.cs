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

        //Events
        public delegate void TurnEvent(int playerIndex, Actor turnPlayer);

        public event TurnEvent OnTurnEnd;
        public event TurnEvent OnTurnStart;

        //Private fields
        private List<Actor> playerList = new List<Actor>();
        private int currentTurnIndex = 0;


        //Interface methods

        public void NextTurn()
        {
            //Fire the OnTurnEnd event
            OnTurnEnd(currentTurnIndex, CurrentTurnPlayer);

            //Move to the next player's turn
            currentTurnIndex++;
            currentTurnIndex %= playerList.Count;

            //Fire the OnTurnStart event
            OnTurnStart(currentTurnIndex, CurrentTurnPlayer);
        }
    }
}
