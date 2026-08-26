using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Presenters.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.Housing
{
    internal class HousingEditorPresenter : IHousingEditorPresenter
    {
        public HousingModel Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;

                if (_model.GlassSocketDiameter > 0)
                {
                    _view.HousingGlassSocketDiameter = _model.GlassSocketDiameter.ToString();
                    _view.HousingMainDiameterPlaceholder = (_model.GlassSocketDiameter * 1.5).ToString();
                }

                if (_model.GlassSocketHeight > 0)
                {
                    _view.HousingGlassSocketHeight = _model.GlassSocketHeight.ToString();
                    _view.HousingMainHeightPlaceholder = (_model.GlassSocketHeight * 1.5).ToString();
                }

                if (_model.MainDiameter > 0)
                {
                    _view.HousingMainDiameter = _model.MainDiameter.ToString();
                }

                if (_model.MainHeight > 0)
                {
                    _view.HousingMainHeight = _model.MainHeight.ToString();
                }
            }
        }

        public void ActivateView()
            => _view.ShowView();

        public HousingEditorPresenter(
            IHousingEditorView view,
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _view = view;
            _view.ClearDataHandler += view_ClearDataHandler;
            _view.CancelDataChangesHandler += view_CancelDataChangesHandler;
            _view.DataChangingHandler += view_DataChangingHandler;

            _view.ConfigChamferHandler += view_ConfigChamferHandler;
            _view.ConfigHolesHandler += view_ConfigHolesHandler;
        }

        private void view_ConfigHolesHandler()
        {
            IHolesEditorPresenter editorPresenter = _serviceProvider.GetRequiredService<IHolesEditorPresenter>();
            editorPresenter.Model = Model.Hole;
            editorPresenter.Containter = Model;
            editorPresenter.ActivateView();
        }

        private void view_ConfigChamferHandler()
        {
           
        }

        private void view_DataChangingHandler()
        {
            _view.ScrewHoleCanBeConfigured = double.TryParse(_view.HousingMainDiameter, out double d) &&
                double.TryParse(_view.HousingMainHeight, out double h) &&
                double.TryParse(_view.HousingGlassSocketDiameter, out double d1) &&
                double.TryParse(_view.HousingGlassSocketHeight, out double h1) &&
                d >= d1 * 1.5 && h > h1;

            _view.ChamferCanBeConfigured = _view.ScrewHoleCanBeConfigured && !Model.Hole.HasErrors;

            _view.IsValid = _view.ScrewHoleCanBeConfigured && 
                !Model.Chamfer.HasErrors &&
                !Model.Hole.HasErrors;
        }

        private void view_CancelDataChangesHandler()
        {
            if (_model.MainDiameter > 0)
            {
                _view.HousingMainDiameter = _model.MainDiameter.ToString();
            }
            else
            {
                _view.HousingMainDiameter = "";
            }


            if (_model.MainHeight > 0)
            {
                _view.HousingMainDiameter = _model.MainHeight.ToString();
            }
            else
            {
                _view.HousingMainDiameter = "";
            }


            if (_model.GlassSocketDiameter > 0)
            {
                _view.HousingGlassSocketDiameter = _model.GlassSocketDiameter.ToString();
            }
            else
            {
                _view.HousingGlassSocketDiameter = "";
            }


            if (_model.GlassSocketHeight > 0)
            {
                _view.HousingGlassSocketHeight = _model.GlassSocketHeight.ToString();
            }
            else
            {
                _view.HousingGlassSocketHeight = _model.GlassSocketHeight.ToString();
            }
        }

        private void view_ClearDataHandler()
        {
            _view.HousingMainDiameter = "";
            _view.HousingMainHeight = "";
        }

        private IHousingEditorView _view;

        private readonly IServiceProvider _serviceProvider;

        private HousingModel _model;
    }
}
