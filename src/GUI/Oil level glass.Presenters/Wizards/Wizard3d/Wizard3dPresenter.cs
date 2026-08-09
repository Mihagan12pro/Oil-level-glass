using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Shared.DataStructues;
using System.Globalization;
using System.Reflection;
using Oil_level_glass.Model.Data.Entities.Parts;
using Shared.Results;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.Core.RubberStrip;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.UI.Abstractions.Editors.Housing;

namespace Oil_level_glass.Presenters.Wizards.Wizard3d
{
    internal class Wizard3dPresenter 
        : IWizard3dPresenter
    {
        private IWizard3dView _wizardView;

        private readonly IGlassView _glassView;
        private readonly IRubberStripEditorView _stripView;
        private readonly IHousingEditorView _housingView;

        private readonly OilLevelGlassModel _oilLevelGlass = new();

        private readonly HousingModel _housing = new();
        private readonly RubberStripModel _rubberStrip = new();
        private readonly GlassModel _glass = new();

        private BaseDetailModel _selectedEntity = null; 

        private readonly Catalog _parts = new();
        private readonly string _tooEarlyForConfiguringMessage;

        public Action CheckData => throw new NotImplementedException();

        public Result CanBeConfigured
        {
            get
            {
                if (_selectedEntity == null)
                    return new Result(false);

                if (_selectedEntity == _rubberStrip && _glass.Error != string.Empty)
                    return new Result(
                        false, 
                        string.Format(
                            _tooEarlyForConfiguringMessage,
                            _glass.DisplayName,
                            _rubberStrip.DisplayName), 
                        FailReason.TooEarlyForConfiguring);

                else if (_selectedEntity == _housing && _rubberStrip.Error != string.Empty)
                    return new Result(
                        false,
                        string.Format(
                            _tooEarlyForConfiguringMessage,
                            _rubberStrip.DisplayName,
                            _housing.DisplayName),
                        FailReason.TooEarlyForConfiguring);

                return new Result(true);
            }
        }

        public Catalog GetParts()
            => _parts;

        public void SetView(IWizard3dView view)
            => _wizardView = view;

        public void SelectPart(string displayName)
        {
            _selectedEntity = typeof(Wizard3dPresenter)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.FieldType.BaseType == typeof(BaseDetailModel))
                .Select(f => f.GetValue(this) as BaseDetailModel)
                .FirstOrDefault(d => d.DisplayName == displayName);
        }

        public void ConfigureSelectedPart()
        {
            _rubberStrip.ExternalDiameter = _glass.Diameter;

            _housing.GlassSocketDiameter = _rubberStrip.ExternalDiameter;

            _housing.GlassSocketHeight = _rubberStrip.Height * 2 + _glass.Height;
            _housing.CentralHoleDiameter = _rubberStrip.InternalDiameter;

            if (_selectedEntity is GlassModel)
            {
                _glassView.Model = _glass;
                _glassView.ShowView(this);
            }
            else if (_selectedEntity is RubberStripModel)
            {
                _stripView.Model = _rubberStrip;
                _stripView.ShowView(this);
            }
            else if (_selectedEntity is HousingModel)
            {
                _housingView.Model = _housing;
                _housingView.ShowView(this);
            }
        }

        public void SetDefaultFolder(string folder)
        {
            _glass.File.Folder = folder;
            _housing.File.Folder = folder;
            _rubberStrip.File.Folder = folder;
        }

        public Wizard3dPresenter(
            IGlassView glassView,
            IRubberStripEditorView rubberStripView,
            IHousingEditorView housingView)
        {
            _glassView = glassView;
            _stripView = rubberStripView;
            _housingView = housingView;

            _glass.Material.Title = "Стекло БК10 ГОСТ 3514-94";
            _glass.Material.Density = 3.12;

            _rubberStrip.Material.Title = "Смесь резиновая 3063 ТУ 38-1051082-86";
            _rubberStrip.Material.Density = 1.28;

            _housing.Material.Title = "Сталь 10 ГОСТ 1050-2013";
            _housing.Material.Density = 7.856;

            switch (CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        _housing.File.Name.Naming = "Корпус";
                        _rubberStrip.File.Name.Naming = "Резиновая прокладка";
                        _glass.File.Name.Naming = "Линза";

                        _parts.Text = "Изделия";
                        _tooEarlyForConfiguringMessage = "Изделие '{0}' должно быть сконфигурировано до изделия '{1}'!";
                        break;
                    }
                default:
                    {
                        _housing.File.Name.Naming = "Housing";
                        _rubberStrip.File.Name.Naming = "Rubber strip";
                        _glass.File.Name.Naming = "Glass";

                        _parts.Text = "Parts";
                        _tooEarlyForConfiguringMessage = "The part '{1}' must be configured before the part '{0}'!";
                        break;
                    }
            }

            Catalog oilLevelGlassCatalog = new Catalog(_oilLevelGlass.DisplayName);
            oilLevelGlassCatalog.AddRange(
                _glass.DisplayName, 
                _rubberStrip.DisplayName,
                _housing.DisplayName);

            _parts.Add(oilLevelGlassCatalog);

            _oilLevelGlass.GlassModel = _glass;
            _oilLevelGlass.RubberStripModel = _rubberStrip;
            _oilLevelGlass.HousingModel = _housing;
        }
    }
}
