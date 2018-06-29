using System;
using System.Linq;

namespace WordCounterModel
{
  public class RepeatCounter
  {
    //Variables
    private string _singleWord;
    private string _multipleWords;
    public string[] wordArray;
    //Constructor
    public RepeatCounter(string firstWord, string manyWords)
    {
      _singleWord = firstWord;
      _multipleWords = manyWords;
    }
    //Methods
    //Getter & Setter for _singleWord
    public string GetSingleWord()
    {
      return _singleWord;
    }
    public void SetSingleWord(string newWord)
    {
      _singleWord = newWord;
    }
    //Getter & Setter for _multipleWords
    public string GetMultpleWords()
    {
      return _multipleWords;
    }
    public void SetMultipleWords(string newWords)
    {
      _multipleWords = newWords;
    }
    //Method to break up the multi-word string into an array of strings
    public string[] CreateStringArray()
    {
      char[] splitCharacters = { ' ', ',', '.', ':', '!', '?', '"', '\'', ';', '-', '_', '/',
      '\\', '@', '#', '$', '%', '^', '&', '*', '(', ')', '[', ']', '{', '}', '+', '=', '<', '>',
      '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '`', '~' };
      string manyWords = this.GetMultpleWords().ToLower();
      wordArray = manyWords.Split(splitCharacters);
      return wordArray;
    }
    //Method that counts and outputs how many times the first word appears in the string of words
    public int WordRepeatCounter()
    {
      string singleWord = this.GetSingleWord().ToLower();
      string[] checkArray = this.CreateStringArray();
      int result = 0;

      foreach(string word in checkArray)
      {
        if(word == singleWord)
        {
          result += 1;
        }
      }
      return result;
    }

  }
}
