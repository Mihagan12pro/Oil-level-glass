using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Entities.Parts.Interfaces;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;

namespace Oil_level_glass.Presenters.Editors.Presenters.HolesEditor
{
    internal class HolesEditorPresenter : IHolesEditorPresenter
    {
        public BasicHoleModel Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public IHoleContainter Containter { get; set; }

        public void ActivateView()
            => _view.ShowView();


        public HolesEditorPresenter(IHolesEditorView view)
        {
            _view = view;
        }


        private readonly IHolesEditorView _view;

        private BasicHoleModel _model;
    }
}
