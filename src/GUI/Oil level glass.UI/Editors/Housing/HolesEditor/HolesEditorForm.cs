using Oil_level_glass.Presenters.Editors.Presenters.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;

namespace Oil_level_glass.UI.Editors.Housing.HolesEditor
{
    public partial class HolesEditorForm : Form, IHolesEditorView
    {
        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;
        public event IHolesEditorView.ConfigHolesCount ConfigHolesCountHandler;
        public event IHolesEditorView.ConfigHolesSizes ConfigHolesSizesHandler;

        public bool IsValid
        {
            get
            {
                return btOk.Enabled;
            }
            set
            {
                btOk.Enabled = value;
            }
        }

        public HolesEditorForm()
        {
            InitializeComponent();

            tvHolesParams.ExpandAll();

            tvHolesParams.NodeMouseDoubleClick += tvHolesParams_NodeMouseDoubleClick;
        }

        private void tvHolesParams_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            if (tvHolesParams.SelectedNode.Name == "nodeCount" && ConfigHolesCountHandler != null)
            {
                ConfigHolesCountHandler(out bool result, out string message);

                if (!result)
                    MessageBox.Show(this, message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tvHolesParams.SelectedNode.Name == "nodeSizes" && ConfigHolesSizesHandler != null)
                ConfigHolesSizesHandler();
        }

        public void ShowView(object owner = null)
        {
            if (owner != null && owner is Form form)
            {
                ShowDialog(form);
            }
            else
            {
                ShowDialog();
            }
        }
    }
}
