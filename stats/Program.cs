using System; 
using System.IO; 

Console.WriteLine("Welcome To this File Statistics Displayer!"); 
Console.WriteLine("Please enter the directory of your file below");
string path = Console.ReadLine(); 
string[] lines = File.ReadAllLines(path);