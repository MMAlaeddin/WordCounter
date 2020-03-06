using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word;
    public string Sentence;
  
    public RepeatCounter(string inputWord, string inputSentence)
    {
      Word = inputWord;
      Sentence = inputSentence;
    }
    public string GetWord()
    {
      if (Word.Contains('1') || Word.Contains('2') || Word.Contains('3') || Word.Contains('4') || Word.Contains('5') || Word.Contains('6') || Word.Contains('7') || Word.Contains('8') || Word.Contains('9') || Word.Contains('0'))
      {
        return "error";
      }
      return Word;
    }
    public bool WordMatch()
    {
      char[] sentArray = Sentence.ToCharArray();
      {
      for (string i = 0; i < sentArray.Length; i ++)
      {
        if (Word.Contains(sentArray[i]))
        {
          return false;
        }
      }
    }
  }
}
