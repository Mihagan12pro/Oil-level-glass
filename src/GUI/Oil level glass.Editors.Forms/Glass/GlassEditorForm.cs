using Oil_level_glass.Editors.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Editors.Forms.Glass
{
    public partial class GlassEditorForm : Form, IGlassEditor
    {
        public GlassEditorForm()
        {
            InitializeComponent();
        }

        public void SetModel(GlassModel model)
        {
            throw new NotImplementedException();
        }
    }
}
