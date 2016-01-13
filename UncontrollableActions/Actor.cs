namespace UncontrollableActions
{
    public class Actor
    {
        public string Name { get { return name; } }

        private string name;
        private readonly Game game;

        public Actor(string name, Game game)
        {
            //Create the actor
            this.name = name;
            this.game = game;

            //Add the actor to the game
            game.AddPlayer(this);
        }
    }
}
