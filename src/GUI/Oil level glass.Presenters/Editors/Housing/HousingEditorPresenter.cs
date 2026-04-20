using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Shared;

namespace Oil_level_glass.Presenters.Editors.Housing
{
    internal class HousingEditorPresenter : IHousingEditorPresenter
    {
        private readonly IHousingForm _housingForm;
        private readonly HousingModel _housing;

        private readonly double _oldExternalDiameter, _oldHolesDiameter;
        private readonly double _oldHeight;
        private readonly double _oldChamferLength, _oldChamferAngle;
        private readonly int _oldHolesCount;

        public Action CheckData { get; }

        public void ResetFields()
        {
            throw new NotImplementedException();
        }

        public Result UpdateMainHeight(string mainHeight)
        {
            throw new NotImplementedException();
        }

        public Result UpdateMainDiameter(string mainDiameter)
        {
            throw new NotImplementedException();
        }

        public Result UpdateScrewHoleDiameter(string screwHoleDiameter)
        {
            throw new NotImplementedException();
        }

        public Result UpdateScrewHolesDictance(string screwHoleDistance)
        {
            throw new NotImplementedException();
        }

        public Result UpdateScrewHolesCount(string screwHolesCount)
        {
            throw new NotImplementedException();
        }

        public Result UpdateChamferLength(string chamferLength)
        {
            throw new NotImplementedException();
        }

        public Result UpdateChamferAngle(string chamferAngle)
        {
            throw new NotImplementedException();
        }

        public HousingEditorPresenter(IHousingForm housingForm, Action checkData)
        {
           
        }
    }
}
