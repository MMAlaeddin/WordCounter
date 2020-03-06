using System;
using System.Collections.Generic;
using System.Linq;

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
    public string CountWord()
    {
      int wordAmount = 0;
      string[] arrayCounter = Sentence.Split(" ");
      foreach (string words in arrayCounter)
      {
        if (words.Contains(Word))
        {
          wordAmount ++;
        }
      }
      return wordAmount;
    }
  }
}
