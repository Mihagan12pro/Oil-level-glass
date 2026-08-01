namespace Oil_level_glass.UI.KompasUtils
{
    public static class GraphicReader
    {
        public static Dictionary<string, IEnumerable<string>> GetByHatch(int hatch)
        {
            Dictionary<string, IEnumerable<string>> dict = new ();

            using(var reader = new StreamReader(KompasSystem.MaterialsFile))
            {
                var sections = reader.ReadToEnd().Split("\r\n");
            }

            return dict;
        }
    }
}
