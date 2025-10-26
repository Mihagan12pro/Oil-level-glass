using KompasData.KompasFile;

namespace Oil_level_glass_Core.Assemblers
{
    public abstract class BaseAssembler
    {
        public required AssemblyFile File { get; set; }

        public abstract void Assemble();
    }
}
