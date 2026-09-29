using System.Text;

namespace FlyweightPattern
{
    public class Sentence
    {
        private readonly List<string> _words;
        private readonly IDictionary<int, WordToken> _wordTokens;

        public Sentence(string plainText)
        {
            _words = [.. plainText.Trim().Split(" ")];
            _wordTokens = new Dictionary<int, WordToken>();
        }

        public WordToken this[int index]
        {
            get
            {
                var token = new WordToken();
                _wordTokens[index] = token;
                return token;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < _words.Count; i++)
            {
                var word = _words[i];
                if (_wordTokens.ContainsKey(i) && _wordTokens[i].Capitalize)
                {
                    word = word.ToUpperInvariant();
                }
                
                sb.Append(word);
                sb.Append(" ");
            }
            sb.Remove(sb.Length-1, 1);

            return sb.ToString();
        }

        public class WordToken
        {
            public bool Capitalize { get; set; }
        }
    }
}
