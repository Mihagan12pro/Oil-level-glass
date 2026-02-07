using Oil_level_glass.Core.Records;

namespace Oil_level_glass.Core
{
    public enum KompasDocumentType
    {
        None,

        SolidPart,

        Assembly
    }

    public interface IConnectionChecker
    {
        DialogResult Check(KompasDocumentType kompasDocument = KompasDocumentType.None);
    }
}
