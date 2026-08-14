using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.ChamferEditor.HelpStructures;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.ChamferEditor
{
    internal class ChamferEditorPresenter 
        : IChamferEditorPresenter
    {
        private readonly IChamferEditorView _form;
        private readonly HousingModel _housing;

        private readonly double _oldChamgerSide1, _oldChamferSide2, _oldChamferAngle;

        public Action CheckData { get; }

        public ChamferDefaultSizes DefaultSizes => throw new NotImplementedException();

        private void CulcSide2()
        {
            double betta = double.DegreesToRadians(90 - _housing.Chamfer.Angle);
            double alpha = double.DegreesToRadians(_housing.Chamfer.Angle);

            _housing.Chamfer.Side2 = Math.Round(Math.Sin(alpha) * _housing.Chamfer.Side1 / Math.Sin(betta), 3);
        }

        public void ResetFields()
        {
            _housing.Chamfer.Side1 = _oldChamgerSide1;
            _housing.Chamfer.Angle = _oldChamferAngle;
            _housing.Chamfer.Side2 = _oldChamferSide2;
        }

        public Result UpdateAngle(string angle)
        {
            var chamfer = _housing.Chamfer;
            var result = chamfer.TryConvertToDoubleAndValidate(angle, nameof(chamfer.Angle));

            CulcSide2();

            return result;
        }

        public Result UpdateSide1(string side1)
        {
            var chamfer = _housing.Chamfer;
            var result = chamfer.TryConvertToDoubleAndValidate(side1, nameof(chamfer.Side1));
            CulcSide2();

            return result;
        }

        public Result UpdateSide2(string side2)
        {
            var chamfer = _housing.Chamfer;

            return chamfer.TryConvertToDoubleAndValidate(side2, nameof(chamfer.Side2));
        }

        public ChamferUpdateResults UpdateModel(ChamferUpdateData updateData)
        {
            throw new NotImplementedException();
        }

        public ChamferEditorPresenter(
            IChamferEditorView form, 
            Action checkData)
        {
            _form = form;

            CheckData = checkData;

            _oldChamgerSide1 = _housing.Chamfer.Side1;
            _oldChamferSide2 = _housing.Chamfer.Side2;
            _oldChamferAngle = (_housing.Chamfer).Angle;
        }
    }
}
