using KompasData.Structs;
namespace KompasData.KompasFile;

public abstract record KompasFile
{
    public Name Name { get; set; }
    
    public string Folder { get; set; }
    
    public string Extension { get; init; }

    public string FullName => $"{Folder}\\{Name.Marking}_{Name.Naming}.{Extension}";
}