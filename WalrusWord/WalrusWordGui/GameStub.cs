namespace EnglishQuestionGui
{
    static class GameStub
    {
        public const int WordCount = 999;

        public static string[] GetVariants()
        {
            return new[] { "Лол 1", "Лол 2", "Лол 3", "Лол 4" };
        }

        public static string[] GetWord()
        {
            return new[] { "Word" };
        }

        public static bool Move(int selectedVariant)
        {
            return true;
        }

        public static int PointsToWin { get; set; }
        public static string PlayerOne { get; set; }
        public static string PlayerTwo { get; set; }


        public static void NewGame(string playerOne, string playerTwo, int pointsToWin)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            PointsToWin = pointsToWin;
        }
    }
}
