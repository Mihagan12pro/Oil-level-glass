using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Shared.DataStructues;
using System.Globalization;
using Oil_level_glass.Model.Data.Entities;
using System.Reflection;
using Oil_level_glass.Model.Data.Entities.Parts;
using Shared.Results;

namespace Oil_level_glass.Presenters.Wizards.Wizard3d
{
    internal class Wizard3dPresenter 
        : IWizard3dPresenter
    {
        private IWizard3dView _wizardView;

        private readonly OilLevelGlassModel _oilLevelGlass = new();

        private readonly HousingModel _housing = new();
        private readonly RubberStripModel _rubberStrip = new();
        private readonly GlassModel _glass = new();

        private BaseEntityModel _selectedEntity = null; 

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

                else if (_selectedEntity == _oilLevelGlass && _housing.Error != string.Empty)
                    return new Result(
                        false,
                        string.Format(
                            _tooEarlyForConfiguringMessage,
                            _housing.DisplayName,
                            _oilLevelGlass.DisplayName),
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
                .Where(f => f.FieldType.BaseType == typeof(BaseDetailModel) || f.FieldType.BaseType == typeof(BaseAssemblyModel))
                .Select(f => f.GetValue(this) as BaseEntityModel)
                .FirstOrDefault(d => d.DisplayName == displayName);
        }

        public Wizard3dPresenter()
        {
            switch(CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        _parts.Text = "Изделия";
                        _tooEarlyForConfiguringMessage = "Изделие '{0}' должно быть сконфигурировано до изделия '{1}'!";
                        break;
                    }
                default:
                    {
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
