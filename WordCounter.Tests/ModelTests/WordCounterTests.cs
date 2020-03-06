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
    public void RepeatCounter_WordMatch_True()
    {
      RepeatCounter newCounter = new RepeatCounter("test", "this is a sentence test");
      string result = newCounter.WordMatch();
      Assert.AreEqual(result, true);
  }
}