namespace knightmoves;

public class FileManager{

    public void Create(string fileName){
           string tempFileName = Path.GetTempFileName();
           string content = "hello file";
           File.WriteAllText(fileName, content);
    }
}
