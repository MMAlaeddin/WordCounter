using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static IEnumerable<String> charList = File.ReadLines("WordCounter/Models/LettersAndNumbers.txt");
    public string Word;
    public string Sentence;
  
    public RepeatCounter(string inputWord, string inputSentence)
    {
      Word = inputWord;
      Sentence = inputSentence;
    }
    public string GetWord()
    {
      foreach (var wrods in charList)
      {
        if (Word.Contains(charList))
        {
          return "error";
        }
      }
      return Word;
    }
  }
}