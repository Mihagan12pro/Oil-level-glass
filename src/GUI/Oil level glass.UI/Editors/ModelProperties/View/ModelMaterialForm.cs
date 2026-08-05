using Oil_level_glass.UI.KompasUtils;
using Oil_level_glass.UI.KompasUtils.Graphic;
using Oil_level_glass.UI.Utils.Extensions;
using Shared.DataStructues;

namespace Oil_level_glass.UI.Editors.Menus.View
{
    public partial class ModelMaterialForm : Form
    {
        public ModelMaterialForm()
        {
            InitializeComponent();
        }

        private void ModelMaterialForm_Load(object sender, EventArgs e)
        {
            GraphicCatalogFiller catalogFiller = new GraphicCatalogFiller(new FileInfo(KompasSystem.MaterialsFile), "Материалы");
            var catalog = catalogFiller.GetCatalog();

            catalog = new GraphicCatalogFilter().FilterLeaves(catalog, (Catalog c) => c.Text.Contains($"|{0}"));
            catalog = new GraphicCatalogFormatter().Format(catalog);

            TreeNode nodes = catalog.ToTreeNode();
            tvMaterials.Nodes.Add(nodes);
            tvMaterials.ExpandAll();
        }
    }
}
