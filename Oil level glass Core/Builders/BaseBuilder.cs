using Kompas6Constants;
using KompasAPI7;
using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;
using Oil_level_glass_Core.Interfaces;

namespace Oil_level_glass_Core.Builders
{
    public abstract class BaseBuilder : BaseAPI7Object, ICreator3D
    {
        public abstract void Build();

        public required PartFile File { get; set; }

        public required Material Material { get; set; }

        public required Appereance Appearance { get; set; }

        public IPart7 Part { get; }

        public IModelContainer ModelContainer { get; }

        public BaseBuilder(bool createNewDocument) : base(createNewDocument)
        {
            if (createNewDocument)
                kompasDocument = application?.Documents.Add(DocumentTypeEnum.ksDocumentPart);
            else
                kompasDocument = application?.ActiveDocument;

            Part = (kompasDocument as IPartDocument)!.TopPart;

            ModelContainer = (IModelContainer)Part;
        }
    }
}
