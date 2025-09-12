using Oil_level_glass_Core.Creators.Creators3D.Builders;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        RingBuilder builder = new RingBuilder();
        builder.ExternalDiameter = 200;
        builder.InternalDiameter = 180;

        builder.Create();
    }
}