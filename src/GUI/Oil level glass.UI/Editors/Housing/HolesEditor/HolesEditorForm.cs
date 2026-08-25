using Oil_level_glass.Presenters.Editors.Presenters.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;

namespace Oil_level_glass.UI.Editors.Housing.HolesEditor
{
    public partial class HolesEditorForm : Form, IHolesEditorView
    {
        private readonly IHolesEditorPresenter _holesEditorPresenter;
        private ErrorProvider _errorsProvider = new ErrorProvider();

        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;

        public bool IsValid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HolesEditorForm()
        {
            InitializeComponent();

            tvHolesParams.ExpandAll();
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
