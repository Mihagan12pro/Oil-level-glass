namespace Oil_level_glass_Core.Data.Structs
{
    public struct Appearance
    {
        public RGB RGB = new RGB();

        public double Ambient { get; set; } = 1;

        public double Diffuse { get; set; } = 1;

        public double Shininess { get; set; } = 1;

        public double Transparency { get; set; } = 1;

        public double Emission { get; set; } = 0.5;

        public Appearance()
        {

        }
    }
}
