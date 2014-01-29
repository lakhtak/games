namespace Logic
{
    public static class OpponentsField
    {
        public static GameField Instance { get; private set; }

        static OpponentsField()
        {
            Instance = new GameField();
        }
    }
}
