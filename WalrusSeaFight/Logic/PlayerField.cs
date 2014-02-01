namespace Logic
{
    public static class PlayerField
    {
        public static GameField Instance { get; private set; }

        static PlayerField()
        {
            Instance = new GameField();
        }
    }
}
