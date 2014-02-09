namespace Logic
{
    public class PlayerField
    {
        public static GameField Instance { get; private set; }

        static PlayerField()
        {
            Instance = new GameField();
        }

        public static void OnGameStateChanged(State state)
        {
            if (state == State.Initial)
                Instance.Clear();
        }
    }
}
