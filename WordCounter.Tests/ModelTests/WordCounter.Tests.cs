using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterModel;

namespace WordCounterTests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void GetSingleWord_ReturnsStoredWord_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello");
      string expected = "hello";
      //Act
      string result = newCount.GetSingleWord();
      //Assert
      Assert.AreEqual(expected, result);
    }
  }

}
