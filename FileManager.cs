namespace knightmoves;

public class FileManager
{
    public void Create(string fileName)
    {
        var name = Path.GetFileName(fileName);
        File.WriteAllText(name, "hello file");
    }
}
