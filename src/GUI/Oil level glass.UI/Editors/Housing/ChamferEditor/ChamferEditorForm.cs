using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;

namespace Oil_level_glass.UI.Editors.Housing.ChamferEditor
{
    public partial class ChamferEditorForm : Form, IChamferEditorForm
    {
        public ChamferEditorForm()
        {
            InitializeComponent();
        }

        public HousingModel Model { get; set; }

        private void ChamferEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
