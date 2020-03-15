using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void RepeatCounter_ReturnInputWord_Word()
    {
      RepeatCounter newCounter = new RepeatCounter("test", "this is a sentence");
      string result = newCounter.GetWord();
      Assert.AreEqual(result, "test");
    }
    [TestMethod]
    public void RepeatCounter_DenyIntegers_Error()
    {
      RepeatCounter newCounter = new RepeatCounter("t3st", "this is a sentence");
      string result = newCounter.GetWord();
      Assert.AreEqual(result, "error");
    }
    [TestMethod]
    public void RepeatCounter_WordMatch_FindWord()
    {
      RepeatCounter newCounter = new RepeatCounter("test", "this is a sentence test");
      string result = newCounter.WordMatch();
      Assert.AreEqual(result, ("test"));
    }
    [TestMethod]
    public void RepeatCounter_WordCount_CountWord()
    {
      string aWord = "test";
      string aSent = "this is a test sentence";
      RepeatCounter newCounter = new RepeatCounter(aWord, aSent);
      int result = newCounter.CountWord();
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void RepeatCounter_OnlyCheckExactWord_CountWord()
    {
      string aWord = "test";
      string aSent = "testing this test sentence test";
      RepeatCounter newCounter = new RepeatCounter(aWord, aSent);
      int result = newCounter.CountWord();
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void RepeatCounter_CountWordMultipleTimes_CountWord()
    {
    string aWord = "test";
    string aSent = "test this test so I can pass my test";
    RepeatCounter newCounter = new RepeatCounter(aWord, aSent);
    int result = newCounter.CountWord();
    Assert.AreEqual(3, result);
    }
  }
}