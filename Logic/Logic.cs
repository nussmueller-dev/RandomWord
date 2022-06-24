﻿namespace RandomWord.Logic {
  public class Logic {
    private Random _random = new Random();
    private IList<string> _words = new List<string>();
    private IList<string> _sentences = new List<string>();

    public Logic() {
      LoadWords();
      LoadSentences();
    }

    private void LoadWords() {
      var wholeText = Properties.Resources._AllWords_;
      _words = wholeText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private void LoadSentences() {
      var wholeText = Properties.Resources._AllSentences_;
      _sentences = wholeText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    public string GetRandomSentence() {
      return _sentences[_random.Next(0, _sentences.Count - 1)];
    }

    public string GetRandomWord() {
      return _words[_random.Next(0, _words.Count - 1)];
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
