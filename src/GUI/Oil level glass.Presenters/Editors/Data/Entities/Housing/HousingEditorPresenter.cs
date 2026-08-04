using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Shared.Results;
using System.Threading;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.Housing
{
    internal class HousingEditorPresenter : IHousingEditorPresenter
    {
        private readonly IHousingForm _housingForm;
        private readonly HousingModel _housing;

        private readonly double _oldMainDiameter, _oldMainHeight;
        private readonly int _oldHolesCount;

        public Action CheckData { get; }

        public void ResetFields()
        {
            _housing.MainDiameter = _oldMainDiameter;
            _housing.MainHeight = _oldMainHeight;

            _housing.ScrewHolesCount = _oldHolesCount;
        }

        public Result UpdateMainDiameter(string mainDiameter)
            => _housing.TryConvertToDoubleAndValidate(mainDiameter, nameof(_housing.MainDiameter));

        public Result UpdateMainHeight(string mainHeight)
            => _housing.TryConvertToDoubleAndValidate(mainHeight, nameof(_housing.MainHeight));

        public HousingEditorPresenter(
            IHousingForm housingForm,
            Action checkData)
        {
            CheckData = checkData;
            _housingForm = housingForm;

            _housing = _housingForm.Model;
        }
    }
}
