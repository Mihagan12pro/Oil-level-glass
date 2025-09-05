using KompasAPI7;
using Oil_level_glass_Core.Data.Files;

namespace Oil_level_glass_Core.Data.ModelProperties
{
    public abstract record ModelProperties<D> where D: IKompasDocument
    {
        public KompasFile? KompasFile { get; init; }

        internal D? KompasDocument { get; set; }
    }
}
