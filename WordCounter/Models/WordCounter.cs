using System;
using System.Collections.Generic;
using System.Text;



namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _countWords;

    public RepeatCounter (string word, string sentence)
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
      return _word.ToLower();

    }
    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence.ToLower();

    }
    public void SetCountWords(int countWords)
    {
      _countWords = countWords;
    }
    public int GetCountWords()
    {
      return _countWords;
    }
    public static string[] SplitText(string text)
    {

      char[] DeleteCharacters = new char[] {',','.','!','?',':',';',' '};
      string[] newsentence = text.Split(DeleteCharacters);
      return newsentence;
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
