using KompasAPI7;
using Oil_level_glass_Core.Data.Files;

namespace Oil_level_glass_Core.Data.ModelProperties
{
    public abstract record ModelProperties
    {
        public KompasFile? KompasFile { get; init; }

        public IKompasDocument? KompasDocument { get; set; }
    }
}
