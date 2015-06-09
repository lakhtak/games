namespace WalrusEngishLogc
{
    public static class Game
    {
        public static Player PlayerOne;
        public static Player PlayerTwo;
        public static Player CurrentPlayer;
        public static int FailsToLose;
        public static int PointsToWin;

        public static TheDictionary WordDictionary;

        public static void StartNew(string playerOneName, string playerTwoName, bool englishRussian, int failsToLose, int pointsToWin)
        {
            WordDictionary = new TheDictionary(englishRussian);
            FailsToLose = failsToLose;
            PointsToWin = pointsToWin;

            PlayerOne = new Player(playerOneName);
            
            if (!string.IsNullOrWhiteSpace(playerTwoName))
                PlayerTwo = new Player(playerTwoName);

            CurrentPlayer = PlayerOne;
        }

        public static void SwitchTurn()
        {
            if (PlayerTwo == null) return;

            CurrentPlayer = CurrentPlayer.Equals(PlayerOne) ? PlayerTwo : PlayerOne;
        }
    }
}
