using Oil_level_glass_Core.Creators.Model3D;

class Program
{
    static void Main()
    {
        HousingCreator housingCreator = new HousingCreator();

        housingCreator.BlankExternalDiameter = 200;
        housingCreator.BlankInternalDiameter = 120;
        housingCreator.BlankHeight = 40;
        housingCreator.DistanceBetweenHoles = 80;

        housingCreator.Create();
    }
}