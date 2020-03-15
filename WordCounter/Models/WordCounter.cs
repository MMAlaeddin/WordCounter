using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }
  
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
    public string GetSentence()
    {
      if (Sentence.Contains('1') || Sentence.Contains('2') || Sentence.Contains('3') || Sentence.Contains('4') || Sentence.Contains('5') || Sentence.Contains('6') || Sentence.Contains('7') || Sentence.Contains('8') || Sentence.Contains('9') || Sentence.Contains('0'))
      {
       return "error";
      }
      return "hello";
    }
    public string WordMatch()
    {
      for (int i = 0; i < Sentence.Length; i ++)
      {
        if (Sentence.Contains(Word))
        {
          return Word;
        }
      }
      return "error";
    }
    public int CountWord()
    {
      int wordAmount = 0;
      string[] arrayCounter = Sentence.Split(" ");
      foreach (string words in arrayCounter)
      {
        if (words == Word)
        {
          wordAmount ++;
        }
      }
      return wordAmount;
    }
  }
}
