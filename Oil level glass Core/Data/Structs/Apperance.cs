namespace Oil_level_glass_Core.Data.Structs
{
    public struct Appearance
    {
        public RGB RGB = new RGB();

        public double Ambient { get; set; } = 100;

        public double Diffuse { get; set; } = 100;

        public double Shininess { get; set; } = 100;

        public double Transparency { get; set; } = 100;

        public double Specularity { get; set; } = 100;

        public double Emission { get; set; } = 50;

        public Appearance()
        {

        }
    }
}
