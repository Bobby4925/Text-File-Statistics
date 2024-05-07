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
    public List<String> getWord(){
        int wordCount = 0; 
        string word = ""; 
        string line = "";
        List<String> words = new List<string>();
        for(int i = 0; i<lines.Length; i++){
            line = lines[i]; 
            for(int j = 0; j<line.Length; j++){
                while(!line[j].Equals(" ")){
                    word+=line[j];
                }
            }
            words.Add(word); 
         }
            return words;
    }
    public int getWordCount(){
        int wordCount = 0;
        List<String> word = getWord();
       return word.Count;
    }

    
 }

