using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;

namespace Oil_level_glass_Core.Builders
{
    public abstract class BaseBuilder
    {
        public abstract void Build();

        public required PartFile File { get; set; }

        public required Material Material { get; set; }

        public required Appereance Appearance { get; set; }
    }
}
