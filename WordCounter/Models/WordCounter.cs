using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
      private int _countMatch;

    public  RepeatCounter(string word, string output)
    {
      _word = word;
      _sentence = sentence;
    }

    public void SetWord(string word)
    {
    _word = word;

    }

    public string GetWord()
    {
      return _word.ToLower;
    }

    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence.ToLower();

    }
    public void SetCountWords(int countMatch)
    {
      _countMatch = countMatch;
    }
    public int GetCountWords()
    {
      return _countMatch;
    }


    public static string[] SplitTheText(string sentence)
    {
    char[] DeleteCharacters = new char[] {',','.','!','?',':',';',' '};
    string[] splitsentence = sentence.Split(DeleteCharacters);
    return splitsentence;
    }

    public static int CountTheWords(string target, string[] words)
    {
      int matches = 0;
      foreach(string word in words)
    {
      if (word.Equals(target))
      {
         matches ++;
      }
    }
      return matches;
    }

  }
}
