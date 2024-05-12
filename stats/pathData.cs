using System.Reflection.Metadata.Ecma335;

public class pathData{
    private string path; 
    private string[] lines; 
    public pathData(string path){
        this.path = path; 
        lines = File.ReadAllLines(path);
        Console.WriteLine("Files Stored!"); 
    }
    public string getPath(){
        return path; 
    }
    public int getLineCount(){
        int lineCount = 0; 
        foreach(string line in lines){
            lineCount++;
        }
     return(lineCount);
    }
    public List<String> getWords(){
        string line = "";
        List<String> words = new List<string>();
        for(int i = 0; i<lines.Length; i++){
            line = lines[i]; 
            if(!string.IsNullOrWhiteSpace(line)){
                string[] word = line.Split(' '); 
                foreach(string w in word){
                    words.Add(w);
                }
            }
         }
            return words;
    }
    public int getWordCount(){
        int wordCount = 0;
        List<String> word = getWords();
        return word.Count;
    }
    public int getCharacterCount(){
        //Excludes White Space
        int characterCount = 0;
        List<String> words = getWords();
        foreach(string s in words){
            characterCount+=s.Length;
        }
        return characterCount; 
    }
    public int uniqueWordCount(){
        //Figure Out How To Get Unique Words
        List<String> words = getWords();
        foreach(string s in words){
        }
        return 1; 
    }
    
 }

