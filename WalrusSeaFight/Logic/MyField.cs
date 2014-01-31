namespace Logic
{
    public static class MyField
    {
        public static GameField Instance { get; private set; }

        static MyField()
        {
            Instance = new GameField();
        }
    }
}
