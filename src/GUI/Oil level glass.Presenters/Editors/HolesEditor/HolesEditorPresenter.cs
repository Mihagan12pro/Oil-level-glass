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

        public HolesDefaultSizes DefaultSizes
            => new HolesDefaultSizes(_oldScrewHoleDiameter, _oldCountOfHoles);

        private IHolesEditorView _holesEditorForm;

        private readonly HousingModel _housingModel;
        private readonly BasicScrewHoleModel _basicScrewHoleModel;

        private readonly int _oldCountOfHoles;
        private readonly double _oldScrewHoleDiameter;

        public void ResetFields()
        {
            ((BasicScrewHoleModel)_housingModel.Hole).Diameter = _oldScrewHoleDiameter;
            _housingModel.ScrewHolesCount = _oldCountOfHoles;
        }

        public HolesUpdateResults UpdateModel(HolesUpdateData updateData)
        {
            var hole = _housingModel.Hole as BasicScrewHoleModel;

            var results = new HolesUpdateResults()
            {
                Diameter = _housingModel.Hole.TryConvertToDoubleAndValidate(updateData.Diameter, nameof(hole.Diameter)),

                Count = _housingModel.TryConvertToInt32AndValidate(updateData.Count, nameof(_housingModel.ScrewHolesCount))
            };


            return results;
        }

        public HolesEditorPresenter(HousingModel housingModel)
        {
            _housingModel = housingModel;
            _basicScrewHoleModel = (BasicScrewHoleModel)_housingModel.Hole;

            _oldCountOfHoles = _housingModel.ScrewHolesCount;
            _oldScrewHoleDiameter = ((BasicScrewHoleModel)_housingModel.Hole).Diameter;
        }
    }
}
