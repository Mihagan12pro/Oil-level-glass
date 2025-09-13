using Oil_level_glass_Core.Creators.Model3D;

class Program
{
    static void Main()
    {
        RingCreator builder = new RingCreator();
        builder.ExternalDiameter = 200;
        builder.InternalDiameter = 180;
        builder.Height = 20;

        builder.Create();
    }
}