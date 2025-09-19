namespace KompasData.KompasFile;

public record PartFile : KompasFile
{
    public PartFile()
    {
        Extension = ".m3d";     
    }
}