using Shared.DataStructues;

namespace Shared.Utils.CatalogUtils
{
    public abstract class CatalogFormatter
    {
        /// <summary>
        /// Gets the formatter used to generate the catalog text.
        /// </summary>
        public abstract Action<Catalog> Formatter { get; }

        /// <summary>
        /// Applies the formatter to the specified catalog
        /// </summary>
        /// <param name="catalog"></param>
        /// <returns></returns>
        public Catalog Format(Catalog catalog)
        {
            if (catalog.Parent == null)
            {
                Formatter.Invoke(catalog);
            }

            for(int i = 0; i < catalog.Count; i++)
            {
                var section = catalog[i];
                Formatter.Invoke(section); 

                if (section.Count > 0)
                {
                    section = Format(section);
                }
            }

            return catalog;
        }
    }
}
