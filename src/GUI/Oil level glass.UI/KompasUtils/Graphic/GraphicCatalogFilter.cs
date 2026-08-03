using Shared.DataStructues;
using Shared.Utils.CatalogUtils;

namespace Oil_level_glass.UI.KompasUtils.Graphic
{
    public class GraphicCatalogFilter : CatalogFilter
    {
        public override Catalog FilterLeaves(
            Catalog catalog, 
            Func<Catalog, bool> filters)
        {
            var filtered = base.FilterLeaves(catalog, filters);

            return filtered;
        }

        protected override Catalog DoFilter(
            Catalog catalog, 
            List<Catalog> forDeleting,
            Func<Catalog, bool> filters)
        {
            for(int i = 0; i < catalog.Count; i++)
            {
                if (catalog[i].Count > 0)
                {
                    var branch = catalog[i];

                    List<Catalog> leavesForDeleting = new List<Catalog>();
                    branch = DoFilter(branch, leavesForDeleting, filters);

                    foreach(var leave in leavesForDeleting)
                    {
                        branch.Remove(leave);
                    }

                    //if (branch.Count == 0 && branch.Parent != null)
                    //{
                    //    var parent = branch.Parent;

                    //    parent.Remove(branch);
                    //}
                }
                else
                {
                    Catalog leave = catalog[i];

                    if (!filters.Invoke(leave))
                        forDeleting.Add(leave);
                }
            }
            
            return catalog;
        }
    }
}
