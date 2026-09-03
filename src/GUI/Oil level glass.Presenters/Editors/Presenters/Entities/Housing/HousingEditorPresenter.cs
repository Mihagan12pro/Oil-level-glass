using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor;
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
            _view.AcceptDataChangesHandler += view_AcceptDataChangesHandler;

            _view.ConfigChamferHandler += view_ConfigChamferHandler;
            _view.ConfigHolesHandler += view_ConfigHolesHandler;
        }

        private void view_AcceptDataChangesHandler()
        {
            Model.MainDiameter = Convert.ToDouble(_view.HousingMainDiameter);
            Model.MainHeight = Convert.ToDouble(_view.HousingMainHeight);

            _view.ScrewHoleCanBeConfigured = true;
            _view.ChamferCanBeConfigured = true;


            _view.IsValid = _view.ScrewHoleCanBeConfigured;

            if (Model.Hole.HasErrors)
            {
                Model.Hole.Diameter = Model.Hole.MaxDiameter;
            }

            if (Model.Chamfer.HasErrors)
            {
                Model.Chamfer.Side1 = Model.Chamfer.MaxSide1;
                Model.Chamfer.Side2 = Model.Chamfer.MaxSide1;
                Model.Chamfer.Angle = 45;
            }
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
            IChamferEditorPresenter editorPresenter = _serviceProvider.GetRequiredService<IChamferEditorPresenter>();
            editorPresenter.Model = Model.Chamfer;
            editorPresenter.ActivateView();
        }

        private void view_DataChangingHandler()
        {
            _view.IsValid = double.TryParse(_view.HousingMainDiameter, out double d) &&
                double.TryParse(_view.HousingMainHeight, out double h) &&
                double.TryParse(_view.HousingGlassSocketDiameter, out double d1) &&
                double.TryParse(_view.HousingGlassSocketHeight, out double h1) &&
                d >= d1 * 1.5 && h > h1;

            if (!_view.IsValid)
            {
                _view.ScrewHoleCanBeConfigured = false;
                _view.ChamferCanBeConfigured = false;
            }
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
                _view.HousingMainHeight = _model.MainHeight.ToString();
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
