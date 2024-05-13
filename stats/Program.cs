Console.WriteLine("Welcome To this File Statistics Displayer!"); 
Console.WriteLine("Please enter the directory of your file below");
string path = Console.ReadLine(); 
int lineCount = 0; 
int wordCount = 0;
int charCount = 0;
int uniqueCount = 0;  
pathData p = new pathData(path); 
//Line Count
lineCount = p.getLineCount();
//Word Count
wordCount = p.getWordCount();
//Character Count
charCount = p.getCharacterCount();
//Unique Word Count 
uniqueCount = p.uniqueWordCount();
Console.WriteLine($"Current Line Count: {lineCount}");
Console.WriteLine($"Current Word Count: {wordCount}");
Console.WriteLine($"Current Character Count: {charCount}");
Console.WriteLine($"Current Unique Word Count: {uniqueCount}"); 
