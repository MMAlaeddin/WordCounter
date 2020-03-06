using System;
using System.Collections.Generic;

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
      if (Word.ToCharArray().Contains('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'))
      {
        return "wrong";
      }
      return Word;
    }
  }
}