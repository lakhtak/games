using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WalrusEngishLogc
{
    internal class TheDictionary
    {
        private Dictionary<string, string> _words;
        private readonly bool _englishRussian;

        public TheDictionary(bool englishRussian)
        {
            _englishRussian = englishRussian;
            LoadWordsFromFile();
        }

        private void LoadWordsFromFile()
        {
            _words = new Dictionary<string, string>();
           
            var lines = File.ReadAllLines("Words.txt", Encoding.Unicode);
            foreach (var line in lines)
            {
                var splittedLine = line.Split(new[] {'|'}, 2);
                if (splittedLine.Count() != 2) continue;

                var word = _englishRussian ? splittedLine[0] : splittedLine[1];
                var translation = _englishRussian ? splittedLine[1] : splittedLine[0];
                
                if (!_words.ContainsKey(word))
                    _words.Add(word, translation);
            }
        }
    }
}
