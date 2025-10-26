namespace KompasData.Materials;
using Kompas6Constants;

public class Rubber : Material
{
    public Rubber()
    {
        MaxDensity = 1.6;

        MinDensity = 0.9;

        HatchStyle = (int)ksHatchStyleEnum.ksHatchNonMetal;
    }
}