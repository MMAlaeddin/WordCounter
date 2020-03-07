using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Word Counter!");
      Console.WriteLine("Please enter a word");
      string newWord = Console.ReadLine();
      Console.WriteLine("Please ender a sentence");
      string newSentence = Console.ReadLine();
      RepeatCounter newCounter = new RepeatCounter(newWord, newSentence);
      int finalOutput = newCounter.CountWord();
      Console.WriteLine("your word " + "~ " + newWord + " ~" + " repeats " + finalOutput + " time(s) in your sentence.");
    }
  }
}