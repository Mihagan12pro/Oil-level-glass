using Shared.DataStructues;
using Shared.Utils.CatalogUtils;
using System.Text.RegularExpressions;

namespace Oil_level_glass.UI.KompasUtils.Graphic
{
    public class GraphicCatalogFormatter : CatalogFormatter
    {
        private readonly Action<Catalog> _formatter;

        public override Action<Catalog> Formatter
            => _formatter;

        public GraphicCatalogFormatter()
        {
            _formatter = (catalog) =>
            {
                if (catalog.Count == 0)
                {
                    var splited = catalog.Text.Split('=');

                    splited[0] = splited[0].TrimStart().TrimEnd();

                    splited[1] = new Regex(@"\|\w*").Replace(
                        
                        splited[1].TrimStart().TrimEnd(), 
                        
                        string.Empty
                    );

                    catalog.Text = string.Format(
                        
                        "{0}, ρ = {1} г/см³", 
                        
                        splited[0], 
                        
                        splited[1]
                    );
                }
            };
        }
    }
}
