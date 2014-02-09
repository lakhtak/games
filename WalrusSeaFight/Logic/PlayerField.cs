namespace Logic
{
    public class PlayerField
    {
        public static GameField Instance { get; private set; }

        static PlayerField()
        {
            Instance = new GameField();
        }

        public static void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState == State.Initial)
                Instance.Clear();
        }
    }
}
