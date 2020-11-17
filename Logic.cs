using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RandomeWord {
  public class Logic {
    private Random random = new Random();
    private IList<string> words = new List<string>();
    private IList<string> sentences = new List<string>();
    public Logic() {
      LoadWords();
      LoadSentences();
    }

    private void LoadWords() {
      string text = File.ReadAllText(@"_AllWords_.txt");
      string[] lines = text.Split(Environment.NewLine);

      foreach (string line in lines) {
        words.Add(line);
      }
    }

    private void LoadSentences() {
      string text = File.ReadAllText(@"_AllSentences_.txt");
      string[] lines = text.Split(Environment.NewLine);

      foreach (string line in lines) {
        sentences.Add(line);
      }
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
