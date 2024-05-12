using System; 
using System.IO; 

Console.WriteLine("Welcome To this File Statistics Displayer!"); 
Console.WriteLine("Please enter the directory of your file below");
//string path = Console.ReadLine(); 
string path = "/Users/ayushb/Desktop/Text File Stats/stats/test.txt";
int lineCount = 0; 
int wordCount = 0;
int charCount = 0; 
pathData p = new pathData(path); 
lineCount = p.getLineCount(); 
<<<<<<< HEAD
wordCount = p.getWordCount();
charCount = p.getCharacterCount();
Console.WriteLine(lineCount);
Console.WriteLine(wordCount);
Console.WriteLine(charCount);
=======
Console.WriteLine(lineCount);
Console.WriteLine(p.getWordCount());
Console.WriteLine(p.getCharacterCount());
>>>>>>> 6bcede2046f41a017b9632e6282f5ac7032319e3

