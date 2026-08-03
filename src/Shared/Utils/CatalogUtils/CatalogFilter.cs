using Shared.DataStructues;

namespace Shared.Utils.CatalogUtils
{
    public abstract class CatalogFilter
    {
        /// <summary>
        /// Filters leaves
        /// </summary>
        /// <param name="catalog"></param>
        /// <param name="filters"></param>
        /// <returns></returns>
        public virtual Catalog FilterLeaves(
            Catalog catalog,
            Func<Catalog, bool> filters)
                => DoFilter(catalog, new List<Catalog>(), filters);

        protected abstract Catalog DoFilter(
            Catalog catalog,
            List<Catalog> forDeleting,
            Func<Catalog, bool> filters);
    }
}
