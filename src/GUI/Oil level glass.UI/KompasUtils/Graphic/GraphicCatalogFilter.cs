using Shared.DataStructues;
using Shared.Utils.CatalogUtils;

namespace Oil_level_glass.UI.KompasUtils.Graphic
{
    public class GraphicCatalogFilter : CatalogFilter
    {
        protected override Catalog DoFilter(
            Catalog catalog, 
            List<Catalog> forDeleting,
            Func<Catalog, bool> filters)
        {
            for(int i = 0; i < catalog.Subsections.Count; i++)
            {
                if (catalog.Subsections[i].Subsections.Count > 0)
                {
                    var branch = catalog.Subsections[i];

                    List<Catalog> leavesForDeleting = new List<Catalog>();
                    branch = DoFilter(branch, leavesForDeleting, filters);

                    foreach(var leave in leavesForDeleting)
                    {
                        branch.Subsections.Remove(leave);
                    }
                }
                else
                {
                    Catalog leave = catalog.Subsections[i];

                    if (!filters.Invoke(leave))
                        forDeleting.Add(leave);
                }
            }
            
            return catalog;
        }
    }
}
