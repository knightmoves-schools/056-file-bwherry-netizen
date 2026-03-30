namespace knightmoves;

public class FileManager{

    public void Create(string fileName){
           fileName = Path.GetFileName();
           string content = "hello file";
           File.WriteAllText(fileName, content);
        
    }
}
