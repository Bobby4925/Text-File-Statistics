using System; 
using System.IO; 

Console.WriteLine("Welcome To this File Statistics Displayer!"); 
Console.WriteLine("Please enter the directory of your file below");
//string path = Console.ReadLine(); 
string path = "/Users/ayushb/Desktop/Text File Stats/stats/test.txt";
int lineCount = 0; 
pathData p = new pathData(path); 
lineCount = p.getLineCount(); 
Console.WriteLine(lineCount);
Console.WriteLine(p.getWordCount());
Console.WriteLine(p.getCharacterCount());

