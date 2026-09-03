using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;
using Oil_level_glass.UI.Forms.Controls;

namespace Oil_level_glass.UI.Editors.ModelProperties
{
    internal class NamingEditorForm : ModelPropertiesEditorForm, INamingEditorView
    {
        public void AddModel(BaseEntityModel model)
        {
            //_presenter.AddModel(model);

            cbMain.Items.Add(model.DisplayName);
            if (cbMain.SelectedIndex > -1)
                cbMain.SelectedIndex = -1;
        }

        public void AddModelsRange(params BaseEntityModel[] models)
        {
            foreach(var model in models)
                AddModel(model);
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
        //public NamingEditorForm(INamingEditorPresenter presenter)
        //    => _presenter = presenter;

        protected override void InitializeComponent()
        {
            base.InitializeComponent();

            tblMain.Controls.Add(_namingEditor, 1, 1);
        }

        private readonly NamingPropertiesChooser _namingEditor = new NamingPropertiesChooser();

        public bool IsValid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // private readonly INamingEditorPresenter _presenter;

        public event IModelPropertyEditorView.PendingForUpdate PendingForUpdateHandler;
        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;
    }
}
