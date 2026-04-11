using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Enums;
using Oil_level_glass.Presenters.Wizards.Wizard3d;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Properties;
using Oil_level_glass.UI.Wizard3d.Editors.Glass;

namespace Oil_level_glass.UI.Wizard3d
{
    public partial class Wizard3dForm : Form, IWizard3dForm
    {
        private readonly IWizard3dPresenter _wizardPresenter;
        private readonly GlassModel _glass;
        private readonly HousingModel _housing;
        private readonly RubberStripModel _rubberStrip;

        public Action<bool> CanCreate { get; }

        public Wizard3dForm()
        {
            InitializeComponent();

            _glass = new GlassModel();
            _rubberStrip = new RubberStripModel();
            _housing = new HousingModel();

            _wizardPresenter = PresentersFactory.CreateWizard3dPresenter(
                this, 
                _glass,
                _rubberStrip,
                _housing,
                () => { 
                    GlassEditorForm form = new GlassEditorForm() 
                    {
                        Owner = this,
                        Model = _glass
                    };
                    form.ShowDialog();
                },
                
                () => {
                    throw new NotImplementedException();
                },
                
                () => {
                    throw new NotImplementedException();
                });

            CanCreate = (bool b) => { btOk.Enabled = b; };
        }

        private void tvParts_DoubleClick(object sender, EventArgs e)
        {
            TreeNode treeNode = tvParts.SelectedNode;

            _wizardPresenter.InvokeEditor(treeNode.Tag);
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

        private void Wizard3dForm_Load(object sender, EventArgs e)
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
    }
}
