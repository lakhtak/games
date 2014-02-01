namespace Logic
{
    public static class GameState
    {
        public static State State { get; set; }

        static GameState()
        {
            State = State.Initial;
        }
    }
}
