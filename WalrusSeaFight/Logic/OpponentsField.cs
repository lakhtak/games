namespace Logic
{
    public class OpponentsField
    {
        public static GameField Instance { get; private set; }

        static OpponentsField()
        {
            Instance = new GameField();
        }

        public static void OnGameStateChanged(State state)
        {
        }
    }
}
