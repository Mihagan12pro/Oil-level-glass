using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.Presenters.Editors.HolesEditor.HelpStructures;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.HolesEditor
{
    internal class HolesEditorPresenter
        : IHolesEditorPresenter
    {
        public Action CheckData { get; }

        public HolesDefaultSizes DefaultSizes => throw new NotImplementedException();

        private IHolesEditorView _holesEditorForm;

        private readonly HousingModel _housingModel;
        private readonly int _oldCountOfHoles;
        private readonly double _oldScrewHoleDiameter;

        public void ResetFields()
        {
            ((BasicScrewHoleModel)_housingModel.Hole).Diameter = _oldScrewHoleDiameter;
            _housingModel.ScrewHolesCount = _oldCountOfHoles;
        }

        public Result UpdateCountOfHoles(string count)
            => _housingModel.TryConvertToInt32AndValidate(count, nameof(_housingModel.ScrewHolesCount));

        public Result UpdateDiameter(string diameter)
        {
            var basic = ((BasicScrewHoleModel)_housingModel.Hole);

            Result result = basic.TryConvertToDoubleAndValidate(diameter, nameof(basic.Diameter));
            if (result.IsSuccess)
            {
                double length = Math.PI * _housingModel.ScrewHolesDistance;

                int newMaxCount = Convert.ToInt32(Math.Floor(length / basic.Diameter));

                if (newMaxCount < 3)
                {
                    return new Result(false, "Count of screw holes can't be less than 3!");
                }

                _housingModel.MaxCountOfHoles = newMaxCount;
            }
            else
            {
                _housingModel.MaxCountOfHoles = 3;
            }

            return result;
        }

        public void SetView(IHolesEditorView view)
        {
            throw new NotImplementedException();
        }

        public HolesUpdateResults UpdateModel(HolesUpdateData updateData)
        {
            throw new NotImplementedException();
        }

        public HolesEditorPresenter(HousingModel housingModel)
        {
            _housingModel = housingModel;

            _oldCountOfHoles = _housingModel.ScrewHolesCount;
            _oldScrewHoleDiameter = ((BasicScrewHoleModel)_housingModel.Hole).Diameter;
        }
    }
}
