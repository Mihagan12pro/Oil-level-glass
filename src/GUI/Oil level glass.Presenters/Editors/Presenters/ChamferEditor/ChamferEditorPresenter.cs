using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor.HelpStructures;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor
{
    internal class ChamferEditorPresenter 
        : IChamferEditorPresenter
    {
        private readonly HousingModel _housing;
        private readonly ChamferModel _chamfer;

        private readonly double _oldChamgerSide1, _oldChamferSide2, _oldChamferAngle;

        public Action CheckData { get; }

        public ChamferDefaultSizes DefaultSizes
            => new ChamferDefaultSizes(_oldChamgerSide1, _oldChamferSide2, _oldChamferAngle, _chamfer.Type);

        public void ResetFields()
        {
            _housing.Chamfer.Side1 = _oldChamgerSide1;
            _housing.Chamfer.Angle = _oldChamferAngle;
            _housing.Chamfer.Side2 = _oldChamferSide2;
        }

        public ChamferUpdateResults UpdateModel(ChamferUpdateData updateData)
        {
            var firstParam = _chamfer.TryConvertToDoubleAndValidate(updateData.Side1, nameof(_chamfer.Side1));

            Result secondParam;
            string thirdParam;

            if (_chamfer.Type == ChamferType.TwoSides)
            {
                secondParam = _chamfer.TryConvertToDoubleAndValidate(updateData.Side2, nameof(_chamfer.Side2));
                thirdParam = _chamfer.Angle.ToString();
            }
            else
            {
                secondParam = _chamfer.TryConvertToDoubleAndValidate(updateData.Angle, nameof(_chamfer.Angle));
                thirdParam = _chamfer.Side2.ToString();
            }

            var result = new ChamferUpdateResults()
            {
                FirstParam = firstParam,

                SecondParam = secondParam,

                ThrirdParam = thirdParam
            };

            return result;
        }

        public void ChangeChamferType(ChamferType chamferType)
            => _chamfer.Type = chamferType;

        public void SetView(IView view)
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
