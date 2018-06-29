Author Name:
Alex Bunnell

Program Name:
Word Counter

Setup Instructions:

    1. Clone the repository from https://github.com/thacheshirecat/WordCounter
    2. navigate to the WordCounter.Solution/WordCounter/Models folder
    3. Run WordCounter.exe

Description:
This program was designed using C# and tested with MSTest. The program allows the user to enter one word, followed by a string of words and the program will evaluate how many times the first word is used in the second string.

Copyright and License Information:
This code utilizes an MIT license

Specs:
1. Program is able to store a string of a single word //
  Input: "hello"  - Output: singleWord = "hello"
2. Program is able to return stored word //
  Input: singleWord  - Output: "hello"
3. Program is able to store a second string of multiple words //
  Input: "the cat hello bird"  - Output: multipleWords = "the cat hello bird"
4. Program is able to return stored string of multiple words  //
  Input: multipleWords - Output: "the cat hello bird"
5. Program is able to break down string of multiple words into a string array //
  Input: "the cat hello bird" - Output: {"the", "cat", "hello", "bird"}
6. Program is able to compare two single word strings //
  Input: "hello"/"hello" - Output: "hello shows up 1 time(s) in the string: hello"
7. Program is able to find each instance of the single word in a string of multiple words //
  Input: "hello"/"the cat hello bird" - Output: "hello shows up 1 time(s) in the string: the cat hello bird"
