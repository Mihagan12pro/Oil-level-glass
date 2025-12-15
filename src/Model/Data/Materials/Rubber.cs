using Kompas6Constants;

namespace Oil_level_glass.Model.Data.Materials;

public class Rubber : Material
{
    public Rubber()
    {
        MaxDensity = 1.6;

        MinDensity = 0.9;

        HatchStyle = (int)ksHatchStyleEnum.ksHatchNonMetal;
    }
}