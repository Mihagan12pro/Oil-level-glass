using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.UI.Presenters.Wizard3d;
using Oil_level_glass.UI.Properties;
using Oil_level_glass.UI.Wizard3d.Editors.Glass;

namespace Oil_level_glass.UI.Wizard3d
{
    enum Part
    {
        OilLevelGlass,
        Glass,
        RubberStrip,
        Housing
    }

    public partial class Wizard3dForm : Form, IWizardForm
    {
        private readonly Wizard3dPresenter _wizardPresenter;
        private readonly GlassModel _glass;
        private readonly HousingModel _housing;
        private readonly RubberStripModel _rubberStrip;

        public Action<bool> CanCreate { get; }

        public Wizard3dForm()
        {
            InitializeComponent();

            InitTreeViewNodes();

            _glass = new GlassModel();
            _rubberStrip = new RubberStripModel();
            _housing = new HousingModel();

            _wizardPresenter = new Wizard3dPresenter(this, _housing, _rubberStrip, _glass);

            CanCreate = (bool b) => { btOk.Enabled = b; };
        }

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
                    GlassEditorForm form = new GlassEditorForm()
                    { 
                        Owner = this,
                        ShowInTaskbar = false,
                        ShowIcon = false
                    };
                    form.ShowDialog();

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

            _wizardPresenter.UpdateModel();
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
