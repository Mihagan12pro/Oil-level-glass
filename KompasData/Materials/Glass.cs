using Kompas6Constants;

namespace Model.Materials;

public class Glass : Material
{
    public Glass()
    {
        MinDensity = 2.2;

        MaxDensity = 7.5;

        HatchStyle = (int)ksHatchStyleEnum.ksHatchGlass;
    }
}