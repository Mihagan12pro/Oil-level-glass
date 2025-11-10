using Kompas6Constants;
using KompasAPI7;
using Oil_level_glass.Model.KompasFile;

namespace Oil_level_glass_Core.Assemblers
{
    public abstract class BaseAssembler : Base3DCreator
    {
        protected readonly IMateConstraints3D mateConstraints;

        internal void AddPartByPath(ref IPart7 part, string path, bool external = false, bool redraw = true)
        {
            part = Part?.Parts.AddFromFile(path, external, redraw)!;
        }


        public BaseAssembler(bool createNewDocument) : base(createNewDocument)
        {
            if (createNewDocument)
                kompasDocument = application?.Documents.Add(DocumentTypeEnum.ksDocumentAssembly);
            else
                kompasDocument = application?.ActiveDocument;

            Part = (kompasDocument as IAssemblyDocument)!.TopPart;
            IAssemblyDocument assemblyDocument = (IAssemblyDocument)kompasDocument!;
            Part = assemblyDocument!.TopPart;

            modelContainer = (IModelContainer)Part;

            mateConstraints = Part.MateConstraints;
        }
    }
}
