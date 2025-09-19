using Kompas6Constants;

namespace KompasData.Materials;

public record Metal : Material
{
    public Metal()
    {
        MinDensity = 0.534;

        MaxDensity = 22.6;

        HatchStyle = (int)ksHatchStyleEnum.ksHatchMetal;
    }
}