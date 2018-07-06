using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Linq;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    //
    //Single word getter and setter test methods
    //
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
    //
    //Multiple word getter and setter test methods
    //
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
    //
    //String Array Tests
    //
    [TestMethod]
    public void CreateStringArray_CreatesAStringArray_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the cat hello bird");
      string[] expected = {"the", "cat", "hello", "bird"};
      //Act
      string[] result = newCount.CreateStringArray();
      bool evaluate = result.SequenceEqual(expected);
      //Assert
      Assert.AreEqual(true, evaluate);
    }
    [TestMethod]
    public void CreateStringArray_ConvertsToLower_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "The Cat Hello Bird");
      string[] expected = {"the", "cat", "hello", "bird"};
      //Act
      string[] result = newCount.CreateStringArray();
      bool evaluate = result.SequenceEqual(expected);
      //Assert
      Assert.AreEqual(true, evaluate);
    }
    [TestMethod]
    public void CreateStringArray_SplitsAtAllDesignatedCharacters_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "q,w.e:r!t?y\"u'i;o-p_a/s\\d@f#g$h%j^k&l*z(x)c[v]b{n}m+q=w<e>r0t1y2u3i4o5p6a7s8d9f`g~h");
      string[] expected = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a",
      "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m", "q", "w", "e",
      "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h" };
      //Act
      string[] result = newCount.CreateStringArray();
      bool evaluate = result.SequenceEqual(expected);
      //Assert
      Assert.AreEqual(true, evaluate);
    }
    //
    //Counter tests
    //
    [TestMethod]
    public void WordRepeatCounter_CanIdentifySameWord_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "hello");
      int expected = 1;
      //Act
      int result = newCount.WordRepeatCounter();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void WordRepeatCounter_CanIdentifySameWordRegardlessOfCase_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "Hello");
      int expected = 1;
      //Act
      int result = newCount.WordRepeatCounter();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void WordRepeatCounter_CanIdentifyWordInStringWithMultipleWords_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the cat hello bird");
      int expected = 1;
      //Act
      int result = newCount.WordRepeatCounter();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void WordRepeatCounter_CanIdentifyWordInStringWithMultipleWordsRegardLessOfCase_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "the cat HElLo bird");
      int expected = 1;
      //Act
      int result = newCount.WordRepeatCounter();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void WordRepeatCounter_CanIdentifyWordInStringWithMultipleWordsRegardLessOfCaseAndSpecialCharacters_True()
    {
      //Assign
      RepeatCounter newCount = new RepeatCounter("hello", "HELLO! $HeLlO? <Hello> ~HellO123");
      int expected = 4;
      //Act
      int result = newCount.WordRepeatCounter();
      //Assert
      Assert.AreEqual(expected, result);
    }
  }

}
