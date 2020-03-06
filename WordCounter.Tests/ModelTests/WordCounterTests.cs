using System;
using System.Collections.Generic;
using System.Linq;
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
      RepeatCounter newCounter = new RepeatCounter("test", "this is a sentence test test test");
      string result = newCounter.CountWord();
      Assert.AreEqual(result, ["test", "test", "test"]);
  }
}