namespace WalrusEngishLogc
{
    public static class Game
    {
        public static Player PlayerOne;
        public static Player PlayerTwo;

        private static TheDictionary _dictionary;

        public static void StartNew(bool englishRussian)
        {
            _dictionary = new TheDictionary(englishRussian);
        }

    }
}
