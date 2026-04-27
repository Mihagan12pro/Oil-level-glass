using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Operations.Chamfers;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Housing.ChamferEditor
{
    internal class ChamferEditorPresenter : IChamferEditorPresenter
    {
        private readonly IChamferEditorForm _form;
        private readonly HousingModel _housing;

        private readonly double _oldChamgerLength, _oldChamferAngle;

        public Action CheckData { get; }

        public void ResetFields()
        {
            _housing.Chamfer.Length = _oldChamgerLength;
            ((ChamferAngleLengthModel)_housing.Chamfer).Angle = _oldChamferAngle;
        }

        public Result UpdateAngle(string angle)
        {
            var chamfer = (ChamferAngleLengthModel)_housing.Chamfer;

            throw new NotImplementedException();
        }

        public Result UpdateLength(string length)
        {
            var chamfer = _housing.Chamfer;

            return chamfer.TryConvertToDouble(length, nameof(chamfer.Length));
        }

        public ChamferEditorPresenter(
            IChamferEditorForm form, 
            Action checkData)
        {
            _form = form;

            CheckData = checkData;

            _housing = _form.Model;

            _oldChamgerLength = _housing.Chamfer.Length;
            _oldChamferAngle = ((ChamferAngleLengthModel)_housing.Chamfer).Angle;
        }
    }
}
