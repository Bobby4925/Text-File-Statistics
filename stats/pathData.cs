using System.Reflection.Metadata.Ecma335;

public class pathData{
    private string path; 
    private string[] lines; 
    public pathData(string path){
        this.path = path; 
    }
    public string getPath(){
        return path; 
    }
    private void setLines(){
        lines = File.ReadAllLines(path);
    }
    public int getLineCount(){
        int lineCount = 0; 
        foreach(string line in lines){
            lineCount++;
        }
     return(lineCount);
    }
    public string getWord(){
        int wordCount = 0; 
        string word = ""; 
        string line = "";
        for(int i = 0; i<lines.Length; i++){
            line = lines[i]; 
            while(!line[i].Equals(" ")){
                word+=line[i];
                return word; 
             }
            }
            return(word);
    }
    public int getWordCount(){
        int wordCount = 0;
        string word = getWord();
        for(int i = 0; i<word.Length; i++){
            wordCount++;
        }
       return wordCount;
    }
 }

