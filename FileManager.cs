namespace knightmoves;

public class FileManager
{
    public void Create(string fileName)
    {
        File.WriteAllText(fileName, "hello file");
    }
}
