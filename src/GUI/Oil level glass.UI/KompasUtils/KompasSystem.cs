namespace Oil_level_glass.UI.KompasUtils
{
    public static class KompasSystem
    {
        public static readonly string KompasDirectory;

        public static readonly string MaterialsFile;

        static KompasSystem()
        {
            KompasDirectory = new DirectoryInfo(
                Environment.GetEnvironmentVariable("KOMPAS_SDK")).Parent.FullName;

            MaterialsFile = new FileInfo(Path.Combine(KompasDirectory, "Sys\\Graphic.dns")).FullName;
        }
    }
}
