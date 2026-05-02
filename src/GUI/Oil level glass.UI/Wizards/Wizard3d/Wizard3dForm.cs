using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Enums;
using Oil_level_glass.Presenters.Wizards.Wizard3d;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Controls;
using Oil_level_glass.UI.Editors.Housing;
using Oil_level_glass.UI.Editors.RubberStrip;
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
            _glass.Material.Title = "Стекло БК10 ГОСТ 3514-94";
            _glass.Material.Density = 3.12;

            _rubberStrip = new RubberStripModel();
            _rubberStrip.Material.Title = "Смесь резиновая 3063 ТУ 38-1051082-86";
            _rubberStrip.Material.Density = 1.28;

            _housing = new HousingModel();
            _housing.Material.Title = "Сталь 10 ГОСТ 1050-2013";
            _housing.Material.Density = 7.856;

            _wizardPresenter = PresentersFactory.CreateWizard3dPresenter(
                this,
                _glass,
                _rubberStrip,
                _housing,
                () =>
                {
                    GlassEditorForm form = new GlassEditorForm()
                    {
                        Owner = this,
                        Model = _glass
                    };
                    form.ShowDialog();
                },

                () =>
                {
                    if (_glass[nameof(_glass.Diameter)] == string.Empty &&
                        _glass[nameof(_glass.Height)] == string.Empty)
                    {
                        RubberStripEditorForm form = new RubberStripEditorForm()
                        {
                            Owner = this,
                            Model = _rubberStrip
                        };
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show(this, "Перед началом конфигурации прокладки необходимо сконфигурировать линзу!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                },

                () =>
                {
                    if (_rubberStrip[nameof(_rubberStrip.ExternalDiameter)] == string.Empty &&
                        _rubberStrip[nameof(_rubberStrip.InternalDiameter)] ==  string.Empty &&
                        _rubberStrip[nameof(_rubberStrip.Height)] == string.Empty)
                    {
                        HousingEditorForm form = new HousingEditorForm()
                        {
                            Owner = this,
                            Model = _housing
                        };
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show(this, "Перед началом конфигурации корпуса необходимо сконфигурировать прокладку!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                },
                () =>
                {
                    btOk.Enabled = (_glass.Error == string.Empty &&
                        _housing.Error == string.Empty &&
                        _rubberStrip.Error == string.Empty);
                },
                () => 
                { 

                });

            _wizardPresenter.SetInitialValues();
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
            tvParts.ExpandAll();

            svpGlass.Tag = Part.Glass;
            svpRubberStrip.Tag = Part.RubberStrip;
            svpHousing.Tag = Part.Housing;

            _wizardPresenter.CheckData();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var result = _wizardPresenter.Create();

            if (!result.IsSuccess)
            {
                MessageBox.Show(this, result.ErrorMessage, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveEditor_UpdateModel(object sender, EventArgs e)
        {
            if (sender is SavingParametersEditor editor)
            {
                _wizardPresenter.UpdatePartSavingParameter(
                      editor.Tag,
                      editor.FolderPath,
                      editor.Naming,
                      editor.Marking);
            }

            _wizardPresenter.CheckData();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            _wizardPresenter.SetInitialValues.Invoke();
        }
    }
}
