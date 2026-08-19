using Oil_level_glass.Model.Data.Entities;
using Oil_level_glass.Model.Data.Entities.Parts;
using Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor;
using Oil_level_glass.Presenters.Editors.ModelProperties.FoldersEditor.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.ModelProperties;
using Oil_level_glass.UI.Forms.Controls;
using System.Net.Http.Headers;

namespace Oil_level_glass.UI.Editors.ModelProperties
{
    internal class FoldersEditorForm : ModelPropertiesEditorForm, IFolderEditorView
    {
        private readonly IFoldersEditorPresenter _presenter;

        private FolderChooser _folderChooser;

        protected override void InitializeComponent()
        {
            base.InitializeComponent();

            _folderChooser = new FolderChooser();
            _folderChooser.Dock = DockStyle.Left;
            _folderChooser.Margin = new Padding(50, 0, 50, 0);
            _folderChooser.Enabled = false;
            tblMain.Controls.Add(_folderChooser, 0, 1);
            _folderChooser.ValueChanged += folderChooser_ValueChanged;

            Text = "Редактор папок";
            FormClosing += foldersEditorForm_FormClosing;
        }

        private void foldersEditorForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (cbMain.SelectedIndex > -1)
            {
                if (MessageBox.Show("Не сохраненные данные будут стерты!", "Вы уверены, что хотите закрыть данное окно?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        protected override void cbMain_SelectedIndexChanged(object? sender, EventArgs e)
        {
            base.cbMain_SelectedIndexChanged(sender, e);

            _folderChooser.Enabled = cbMain.SelectedIndex > -1;
            _presenter.SelectModel(cbMain.SelectedIndex);

            if (_folderChooser.Enabled)
            {
                _folderChooser.Folder = _presenter.DefaultSizes.Folder;
            }
        }

        private void folderChooser_ValueChanged()
            => btOk.Enabled = _folderChooser.IsValid;

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

        public void AddModel(BaseEntityModel model)
        {
            if (model is BaseDetailModel detailModel)
            {
                _presenter.AddModel(detailModel);

                cbMain.Items.Add(model.DisplayName);
                if (cbMain.SelectedIndex > -1)
                    cbMain.SelectedIndex = -1;
            }
        }

        public void AddModelsRange(params BaseEntityModel[] models)
        {
            foreach(var model in models)
                AddModel(model);
        }

        protected override void btCancel_Click(object? sender, EventArgs e)
        {
            if (cbMain.SelectedIndex == -1)
            {
                base.btCancel_Click(sender, e);

                return;
            }

            _folderChooser.Folder = _presenter.DefaultSizes.Folder;
        }

        protected override void btOk_Click(object? sender, EventArgs e)
        {
            if (_presenter.UpdateModel(new FolderUpdateData(_folderChooser.Folder)).NoErrors)
            {
                cbMain.SelectedIndex = -1;
                _folderChooser.Folder = string.Empty;
            }
        }

        public FoldersEditorForm(IFoldersEditorPresenter presenter)
        {
            _presenter = presenter;
        }
    }
}
