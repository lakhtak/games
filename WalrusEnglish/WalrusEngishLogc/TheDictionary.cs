using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WalrusEngishLogc
{
    public class TheDictionary
    {
        private Dictionary<string, string> _words;
        private List<string> _variants;
        private readonly bool _englishRussian;
        private KeyValuePair<string, string> _currentWord;
        private readonly Random _random = new Random();

        public TheDictionary(bool englishRussian)
        {
            _englishRussian = englishRussian;
            LoadWordsFromFile();
        }

        private void LoadWordsFromFile()
        {
            _words = new Dictionary<string, string>();
            _variants = new List<string>();

            var lines = File.ReadAllLines("Words.txt", Encoding.Unicode);
            foreach (var line in lines)
            {
                var splittedLine = line.Split(new[] {'|'}, 2);
                if (splittedLine.Count() != 2) continue;

                var word = _englishRussian ? splittedLine[0] : splittedLine[1];
                var translation = _englishRussian ? splittedLine[1] : splittedLine[0];

                if (_words.ContainsKey(word)) continue;
                
                _words.Add(word, translation);
                _variants.Add(translation);
            }
        }

        public string GetNextWord()
        {
            if (!_words.Any())
                LoadWordsFromFile();

            var randomWord = _words.ElementAt(_random.Next(_words.Count() - 1));
            _currentWord = new KeyValuePair<string, string>(randomWord.Key, randomWord.Value);
            _words.Remove(randomWord.Key);
            return _currentWord.Key;
        }

        public string[] GetVariants()
        {
            var randomVariants = new string[4];
            var variantsExceptCurrent = _variants.Where(variant => !variant.Equals(_currentWord.Value)).ToArray();
            var randoms = GenerateRandomArray(randomVariants.Count(), variantsExceptCurrent.Count() - 1);
            for (var i = 0; i < randomVariants.Count(); i++)
                randomVariants[i] = variantsExceptCurrent[randoms[i]];
            
            randomVariants[_random.Next(randomVariants.Count() - 1)] = _currentWord.Value;

            return randomVariants;
        }

        private int[] GenerateRandomArray(int count, int maxValue)
        {
            var randomArray = new List<int>();
            do
            {
                var randomValue = _random.Next(maxValue);
                if (!randomArray.Contains(randomValue))
                    randomArray.Add(randomValue);
            } while (randomArray.Count < count);
            return randomArray.ToArray();
        }

        public bool IsAnswerCorrect(string answer)
        {
            return answer.Equals(_currentWord.Value, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
