using KompasAPI7;
using Oil_level_glass.Model.KompasFile;

namespace Oil_level_glass_Core.Assemblers
{
    public abstract class BaseAssembler : BaseCreator
    {
        internal IPart7? Assemble;

        public required AssemblyFile File { get; set; }

        internal void AddPartByPath(ref IPart7 part, string path, bool external = false, bool redraw = true)
        {
            part = Assemble?.Parts.AddFromFile(path, external, redraw)!;
        }

        public BaseAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
