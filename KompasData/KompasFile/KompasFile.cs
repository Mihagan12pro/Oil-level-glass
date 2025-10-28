using KompasData.Other;
namespace KompasData.KompasFile;

public abstract class KompasFile
{
    public Name Name { get; }
    
    public string ?Folder { get; set; }
    
    public string ?Extension { get; init; }

    public string FullName => $"{Folder}\\{Name.Marking}_{Name.Naming}.{Extension}";

    public KompasFile()
    {
        Name = new Name();
    }
}