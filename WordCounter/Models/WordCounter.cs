using System;

namespace WordCounterModel
{
  public class RepeatCounter
  {
    //Variables
    private string _singleWord;
    private string _multipleWords;
    public string[] wordArray;
    //Constructor
    public RepeatCounter(string firstWord)
    {
      _singleWord = firstWord;
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
    
  }
}
