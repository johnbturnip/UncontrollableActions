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

        //Private fields
        private List<Actor> playerList = new List<Actor>();
        private int currentTurnIndex = 0;

    }
}
