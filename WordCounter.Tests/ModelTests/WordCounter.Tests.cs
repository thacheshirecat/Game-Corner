using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterModel;
//Assign
//Act
//Assert
namespace WordCounterTests
{
  [TestClass]
  public class RepeatCounterTests
  {
    //Single word getter and setter test methods
    [TestMethod]
    public void GetSingleWord_ReturnsStoredWord_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the cat hello bird");
      string expected = "hello";
      //Act
      string result = newCount.GetSingleWord();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void GetSingleWord_DoesNotIgnoreCase_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("Hello", "the cat hello bird");
      string expected = "hello";
      //Act
      string result = newCount.GetSingleWord();
      //Assert
      Assert.AreNotEqual(expected, result);
    }
    [TestMethod]
    public void SetSingleWord_AbleToChangeSingleWord_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("cat", "the cat hello bird");
      string expected = "hello";
      //Act
      newCount.SetSingleWord("hello");
      string result = newCount.GetSingleWord();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void SetSingleWord_DoesNotIgnoreCase_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("cat", "the cat hello bird");
      string expected = "hello";
      //Act
      newCount.SetSingleWord("Hello");
      string result = newCount.GetSingleWord();
      //Assert
      Assert.AreNotEqual(expected, result);
    }
    //Multiple word getter and setter test methods
    [TestMethod]
    public void GetMultpleWords_ReturnsStoredWords_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the cat hello bird");
      string expected = "the cat hello bird";
      //Act
      string result = newCount.GetMultpleWords();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void GetMultpleWords_DoesNotIgnoreCase_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the Cat hello bird");
      string expected = "the cat hello bird";
      //Act
      string result = newCount.GetMultpleWords();
      //Assert
      Assert.AreNotEqual(expected, result);
    }
    [TestMethod]
    public void SetMultipleWords_AbleToChangeMultipleWords_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the cat");
      string expected = "the cat hello bird";
      //Act
      newCount.SetMultipleWords("the cat hello bird");
      string result = newCount.GetMultpleWords();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void SetMultipleWords_DoesNotIgnoreCase_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the cat");
      string expected = "the cat hello bird";
      //Act
      newCount.SetMultipleWords("the Cat hello bird");
      string result = newCount.GetMultpleWords();
      //Assert
      Assert.AreNotEqual(expected, result);
    }
  }

}
