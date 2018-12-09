using System;
using System.Collections.Generic;
using System.Text;



namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;

    public RepeatCounter (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    public string GetWord()
    {
      return _word.ToLower();

    }

    public void SetWord(string word)
    {
      _word = word;
    }



    public string GetSentence()
    {
      return _sentence.ToLower();

    }

    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }



    public string[] SplitText()
    {
      string[] words = _sentence.Split(' ');
      return words;
    }

    public int CountTheWords()
    {
      int result = 0;
      foreach (string word in SplitText())
      {
        if (word == _word)
        {
          result++;
        }
      }
      return result;
    }
  }
}
