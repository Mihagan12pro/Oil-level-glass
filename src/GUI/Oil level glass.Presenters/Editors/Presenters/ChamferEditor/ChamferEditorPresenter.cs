using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.UI.Abstractions;

namespace Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor
{
    internal class ChamferEditorPresenter : IChamferEditorPresenter
    {
        private readonly HousingModel _housing;
        private readonly ChamferModel _chamfer;

        private readonly double _oldChamgerSide1, _oldChamferSide2, _oldChamferAngle;

        public ChamferModel Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ResetFields()
        {
            _housing.Chamfer.Side1 = _oldChamgerSide1;
            _housing.Chamfer.Angle = _oldChamferAngle;
            _housing.Chamfer.Side2 = _oldChamferSide2;
        }

        public void ChangeChamferType(ChamferType chamferType)
            => _chamfer.Type = chamferType;

        public void SetView(IView view)
        {
            throw new NotImplementedException();
        }

        public void ActivateView()
        {
            throw new NotImplementedException();
        }

        public ChamferEditorPresenter(HousingModel housing)
        {
            _housing = housing;
            _chamfer = _housing.Chamfer;

            _oldChamgerSide1 = _housing.Chamfer.Side1;
            _oldChamferSide2 = _housing.Chamfer.Side2;
            _oldChamferAngle = (_housing.Chamfer).Angle;
        }
    }
}
