namespace UncontrollableActions
{
    public class Actor
    {
        //Public properties
        public string Name { get { return name; } }

        public double Arousal
        {
            get { return arousal; }
            set { ChangeStat(ref arousal, value, OnArousalChanged); }
        }
        public double Stimulus
        {
            get { return stimulus; }
            set { ChangeStat(ref stimulus, value, OnStimulusChanged); }
        }

        //Events
        public delegate void StatChangedEvent(Actor actor, double oldVal, double newVal);

        public static event StatChangedEvent OnArousalChanged;
        public static event StatChangedEvent OnStimulusChanged;

        //Private fields
        private string name;
        private readonly Game game;

        private double arousal = 0;
        private double stimulus = 0;

        public Actor(string name, Game game)
        {
            //Create the actor
            this.name = name;
            this.game = game;

            //Add the actor to the game
            game.AddPlayer(this);
        }


        //Misc methods
        private void ChangeStat(ref double stat, double newVal, StatChangedEvent EventMethod)
        {
            //Change the stat.
            double oldVal = stat;
            stat = newVal;

            //Send the event
            if (EventMethod != null)
            {
                EventMethod(this, oldVal, stat);
            }
        }
    }
}
