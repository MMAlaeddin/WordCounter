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
  }
}