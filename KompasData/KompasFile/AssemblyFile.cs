namespace KompasData.KompasFile;

public record AssemblyFile : KompasFile
{
    public AssemblyFile()
    {
        Extension = ".a3d";
    }
}