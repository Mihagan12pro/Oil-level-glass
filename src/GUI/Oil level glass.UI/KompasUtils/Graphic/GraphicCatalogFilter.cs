using Shared.DataStructues;
using Shared.Utils.CatalogUtils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Oil_level_glass.UI.KompasUtils.Graphic
{
    public class GraphicCatalogFilter : CatalogFilter
    {
        public override Catalog FilterLeaves(
            Catalog catalog, 
            Func<Catalog, bool> filters)
        {
            var filter = (Catalog c) => c.Count > 0 || c.Text.Contains('|');

            var filtered = DoFilter(
                
                base.FilterLeaves(catalog, filters),
                
                new Queue<Catalog>(),
                
                filter
            );

            filtered = DoFilter(
                
                    filtered,
                
                    new Queue<Catalog>(),
                
                    filter
            );

            return filtered;
        }

        protected override Catalog DoFilter(
            Catalog catalog, 
            Queue<Catalog> forDeleting,
            Func<Catalog, bool> filters)
        {
            for(int i = 0; i < catalog.Count; i++)
            {
                if (catalog[i].Count > 0)
                {
                    var branch = catalog[i];

                    Queue<Catalog> leavesForDeleting = new Queue<Catalog>();
                    branch = DoFilter(branch, leavesForDeleting, filters);

                    while(leavesForDeleting.TryDequeue(out Catalog leave))
                    {
                        branch.Remove(leave);
                    }
                }
                else
                {
                    Catalog leave = catalog[i];

                    if (filters.Invoke(leave) == false)
                        forDeleting.Enqueue(leave);
                }
            }

            while (forDeleting.TryDequeue(out Catalog leave))
            {
                catalog.Remove(leave);
            }

            return catalog;
        }
    }
}
