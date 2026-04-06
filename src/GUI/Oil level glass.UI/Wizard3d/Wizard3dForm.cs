using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.UI.Main;
using Oil_level_glass.UI.Properties;

namespace Oil_level_glass.UI.Wizard3d
{
    enum Part
    {
        OilLevelGlass,
        Glass,
        RubberStrip,
        Housing
    }

    public partial class Wizard3dForm : Form, IMainForm
    {
        private readonly MainPresenter _mainPresenter;

        public Wizard3dForm()
        {
            InitializeComponent();

            InitTreeViewNodes();

            _mainPresenter = new MainPresenter(this);
        }

        public event EventHandler UpdateDiameterTextBox = delegate { };

        private void InitTreeViewNodes()
        {
            TreeNode[] details = new TreeNode[]
            {
                new TreeNode(Resources.Glass) { Tag = Part.Glass },
                new TreeNode(Resources.RubberStrip) { Tag = Part.RubberStrip },
                new TreeNode(Resources.Housing) { Tag = Part.Housing }
            };

            TreeNode oilLevelGlassNode = new TreeNode(Resources.OilLevelGlass, details) { Tag = Part.OilLevelGlass };

            tvParts.Nodes.Add(oilLevelGlassNode);
        }

        private void tvParts_DoubleClick(object sender, EventArgs e)
        {
            TreeNode treeNode = tvParts.SelectedNode;

            switch (treeNode.Tag)
            {
                case Part.Glass:

                    break;

                case Part.RubberStrip:

                    break;

                case Part.Housing:

                    break;

                case Part.OilLevelGlass:

                    break;

                default:

                    break;
            }
        }

        private void tvParts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvParts.SelectedNode != null)
            {
                TreeNode treeNode = tvParts.SelectedNode;
                Image sketch;

                switch (treeNode.Tag)
                {
                    case Part.Glass:
                        sketch = Resources.Glass_Img;
                        break;

                    case Part.RubberStrip:
                        sketch = Resources.Rubber_strip_Img;
                        break;

                    case Part.Housing:
                        sketch = Resources.Housing_Img;
                        break;

                    case Part.OilLevelGlass:
                        sketch = Resources.Oil_level_glass_Img;
                        break;

                    default:
                        sketch = Resources.Oil_level_glass_Img;
                        break;
                }

                pbSketch.Image = sketch;
            }
        }
    }
}
