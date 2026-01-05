using Kompas6API5;
using Kompas6Constants;
using KompasAPI7;

namespace Oil_level_glass.COM.Extensions
{
    internal static class KompasObjectExtensions
    {
        public static IPartDocument GetPartDocument(this KompasObject kompas, bool newDocument = true)
        {
            IApplication application = (IApplication)kompas.ksGetApplication7();

            if (newDocument)
                return (IPartDocument)application.Documents.Add(DocumentTypeEnum.ksDocumentPart);

            IPartDocument document = (IPartDocument)application.ActiveDocument;

            return document;
        }
        public static IAssemblyDocument GetAssemblyDocument(this KompasObject kompas, bool newDocument = true)
        {
            IApplication application = (IApplication)kompas.ksGetApplication7();

            if (newDocument)
                return (IAssemblyDocument)application.Documents.Add(DocumentTypeEnum.ksDocumentAssembly);

            IAssemblyDocument document = (IAssemblyDocument)application.ActiveDocument;

            return document;
        }

    }
}
