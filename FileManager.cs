namespace knightmoves;

public class FileManager{

    public void Create(string fileName){
           fileName = Path.GetfileName();
           string content = "hello file";
           File.WriteAllText(fileName, content);
    }
}
