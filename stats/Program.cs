using System; 
using System.IO; 

Console.WriteLine("Welcome To this File Statistics Displayer!"); 
Console.WriteLine("Please enter the directory of your file below");
string path = Console.ReadLine(); 
int lineCount = 0; 
int wordCount = 0;
int charCount = 0; 
pathData p = new pathData(path); 
lineCount = p.getLineCount(); 
wordCount = p.getWordCount();
charCount = p.getCharacterCount();
Console.WriteLine(lineCount);
Console.WriteLine(wordCount);
Console.WriteLine(charCount);

