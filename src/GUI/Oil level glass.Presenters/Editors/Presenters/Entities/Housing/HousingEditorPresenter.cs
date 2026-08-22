using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Presenters.Entities.Housing.DataStructures;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.Housing
{
    internal class HousingEditorPresenter : IHousingEditorPresenter
    {
        private IHousingEditorView _housingForm;

        private readonly IServiceProvider _serviceProvider;

        private readonly HousingModel _housing;

        private readonly double _oldMainDiameter, _oldMainHeight;
        private readonly int _oldHolesCount;

        public Action CheckData { get; }

        public HousingDefaultSizes DefaultSizes
        {
            get
            {
                return new HousingDefaultSizes(
                    _oldMainDiameter,
                    _housing.GlassSocketDiameter,
                    _oldMainHeight,
                    _housing.GlassSocketHeight);
            }
        }

        public bool ScrewHoleCanBeConfigured
            => _housing[nameof(_housing.MainHeight)] == string.Empty &&
               _housing[nameof(_housing.MainDiameter)] == string.Empty;

        public bool ChamferCanBeConfigured
            => _housing.Hole.HasErrors == false;

        public void ResetFields()
        {
            _housing.MainDiameter = _oldMainDiameter;
            _housing.MainHeight = _oldMainHeight;

            _housing.ScrewHolesCount = _oldHolesCount;
        }

        public void SetView(IHousingEditorView view)
        {
            _housingForm = view;
        }

        public HousingUpdateResults UpdateModel(HousingUpdateData updateData)
        {
            HousingUpdateResults housingUpdateResults = new HousingUpdateResults()
            {
                MainDiameter = _housing.TryConvertToDoubleAndValidate(updateData.MainDiameter, nameof(_housing.MainDiameter)),

                MainHeight = _housing.TryConvertToDoubleAndValidate(updateData.MainHeight, nameof(_housing.MainHeight))
            };

            return housingUpdateResults;
        }

        public void ConfigureChamfer()
        {
            _housing.UpdateComputableFields();

            using (IChamferEditorView chamferEditorView = _serviceProvider.GetRequiredService<IChamferEditorView>())
            {
                chamferEditorView.ShowView();
            }
        }

        public void ConfigureHoles()
        {
            _housing.UpdateComputableFields();

            using (IHolesEditorView holesEditorForm = _serviceProvider.GetRequiredService<IHolesEditorView>())
            {
                holesEditorForm.ShowView();
            }
        }

        public void SetView(IView view)
        {
            throw new NotImplementedException();
        }

        public HousingEditorPresenter(
            HousingModel housing,
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _housing = housing;

             _oldMainDiameter = _housing.MainDiameter;
            _oldMainHeight = _housing.MainHeight;

            _oldHolesCount = _housing.ScrewHolesCount;
        }
    }
}
