using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;

namespace Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor
{
    internal class ChamferEditorPresenter : IChamferEditorPresenter
    {
        private readonly ChamferModel _chamfer;

        private readonly IChamferEditorView _view;

        public ChamferModel Model { get; set; }

        public void ResetFields()
        {
            //_housing.Chamfer.Side1 = _oldChamgerSide1;
            //_housing.Chamfer.Angle = _oldChamferAngle;
            //_housing.Chamfer.Side2 = _oldChamferSide2;
        }

        public void ActivateView()
            => _view.ShowView();

        public void ChangeChamferType(bool isAngleSide)
        {
            if (isAngleSide)
            {
                Model.Type = ChamferType.SideAndAngle;

                return;
            }

            Model.Type = ChamferType.TwoSides;
        }

        public ChamferEditorPresenter(IChamferEditorView view)
        {
            _view = view;
        }
    }
}
