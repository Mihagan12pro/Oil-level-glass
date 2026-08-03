using Shared.DataStructues;
using Shared.Utils.CatalogUtils;

namespace Oil_level_glass.UI.KompasUtils.Graphic
{
    public class GraphicCatalogFiller : CatalogFiller
    {
        public GraphicCatalogFiller(
            FileInfo sourceFile, 
            string rootName) : base(sourceFile, rootName)
        {
        }

        public GraphicCatalogFiller(
            string source, 
            string rootName) : base(source, rootName)
        {
        }

        public GraphicCatalogFiller(
            string[] source, 
            string rootName) : base(source, rootName)
        {
        }

        protected override Catalog Fill(Catalog catalog)
        {
            while(sourceLines.Count > 0)
            {
                string line = sourceLines.Dequeue();

                if (line.Contains('{'))
                {
                    line = line.Replace("{", string.Empty)
                               .TrimStart()
                               .TrimEnd();

                    Catalog section = Fill(new Catalog() { Value = line });


                    catalog.Add(section);
                }
                else if (line.Contains('}'))
                {
                    return catalog;
                }
                else
                {
                    line = line.TrimStart()
                               .TrimEnd();

                    if (line.Length > 0)
                    {
                        catalog.Add(new Catalog() { Value = line });
                    }
                }
            }

            return catalog;
        }
    }
}
