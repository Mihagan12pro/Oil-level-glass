using Kompas6Constants;

namespace KompasData.Materials;

public class Glass : Material
{
    public Glass()
    {
        MinDensity = 2.2;

        MaxDensity = 7.5;

        HatchStyle = (int)ksHatchStyleEnum.ksHatchGlass;
    }
}