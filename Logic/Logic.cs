namespace RandomWord.Logic {
  public class Logic {
    private Random random = new Random();
    private IList<string> words = new List<string>();
    private IList<string> sentences = new List<string>();

    public Logic() {
      LoadWords();
      LoadSentences();
    }

    private void LoadWords() {
      var wholeText = Properties.Resources._AllWords_;
      words = wholeText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private void LoadSentences() {
      var wholeText = Properties.Resources._AllSentences_;
      sentences = wholeText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    public string GetRandomSentence() {
      return sentences[random.Next(0, sentences.Count - 1)];
    }

    public string GetRandomWord() {
      return words[random.Next(0, words.Count - 1)];
    }

    public string GetRandomNoun() {
      string word;

      do {
        word = GetRandomWord();
      } while (word[0].ToString() != word[0].ToString().ToUpper());

      return word;
    }
  }
}
