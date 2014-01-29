namespace Logic
{
    public static class MyGameField
    {
        public static GameField Instance { get; private set; }

        static MyGameField()
        {
            Instance = new GameField();
        }
    }
}
