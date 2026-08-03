namespace Shared.DataStructues.CatalogUtils
{
    public class Catalog
    {
        public string Value { get; set; }

        public List<Catalog> Subsections { get; } = new ();
    }
}
