using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Shared.Results;
using System.Threading;

namespace Oil_level_glass.Presenters.Editors.Housing
{
    internal class HousingEditorPresenter : IHousingEditorPresenter
    {
        private readonly IHousingForm _housingForm;
        private readonly HousingModel _housing;

        private readonly double _oldMainDiameter, _oldMainHeight;
        private readonly double  _oldHolesDiameter, _oldHolesPitch;
        private readonly int _oldHolesCount;

        private readonly double _oldChamferLength, _oldChamferAngle;

        public Action CheckData { get; }

        public void ResetFields()
        {
            _housing.MainDiameter = _oldMainDiameter;
            _housing.MainHeight = _oldMainHeight;

            _housing.ScrewHolesCount = _oldHolesCount;
            _housing.Thread.NominalDiameter = _oldHolesDiameter;
            _housing.Thread.Pitch = _oldHolesPitch;

            _housing.Chamfer.Angle = _oldChamferAngle;
            _housing.Chamfer.Length = _oldChamferLength;
        }

        public Result UpdateMainHeight(string mainHeight)
            => _housing.TryConvertToDouble(mainHeight, nameof(_housing.MainHeight));

        public Result UpdateMainDiameter(string mainDiameter)
            => _housing.TryConvertToDouble(mainDiameter, nameof(_housing.MainDiameter));

        public Result UpdateScrewHoleDiameter(string screwHoleDiameter)
            => _housing.Thread.TryConvertToDouble(screwHoleDiameter, nameof(_housing.Thread.NominalDiameter));
        public Result UpdatePicth(string pitch)
             => _housing.Thread.TryConvertToDouble(pitch, nameof(_housing.Thread.Pitch));

        public Result UpdateScrewHolesDictance(string screwHoleDistance)
            => _housing.TryConvertToDouble(screwHoleDistance, nameof(_housing.ScrewHolesDistance));

        public Result UpdateScrewHolesCount(string screwHolesCount)
            => _housing.TryConvertToInt32(screwHolesCount, nameof(_housing.ScrewHolesCount));

        public Result UpdateChamferLength(string chamferLength)
            => _housing.Chamfer.TryConvertToDouble(chamferLength, nameof(_housing.Chamfer.Length));

        public Result UpdateChamferAngle(string chamferAngle)
            => _housing.Chamfer.TryConvertToDouble(chamferAngle, nameof(_housing.Chamfer.Angle));

        public HousingEditorPresenter(
            IHousingForm housingForm,
            Action checkData)
        {
            CheckData = checkData;
            _housingForm = housingForm;

            _housing = _housingForm.Model;

            _oldMainDiameter = _housing.MainDiameter;
            _oldMainHeight = _housing.MainHeight;

            _oldHolesCount = _housing.ScrewHolesCount;
            _oldHolesDiameter = _housing.Thread.NominalDiameter;
            _oldHolesPitch = _housing.Thread.Pitch;

            _oldChamferAngle = _housing.Chamfer.Angle;
            _oldChamferLength = _housing.Chamfer.Length;
        }
    }
}
