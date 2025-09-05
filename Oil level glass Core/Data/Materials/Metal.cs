using Kompas6Constants;

namespace Oil_level_glass_Core.Data.Materials
{
    public record Metal : Material
    {
        public Metal()
        {
            MinDensity = 0.534;

            MaxDensity = 22.6;

            HatchStyle = (int)ksHatchStyleEnum.ksHatchMetal;
        }
    }
}
