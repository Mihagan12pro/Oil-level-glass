using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Shared.Results;
using System.Globalization;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.Glass
{
    internal class GlassEditorPresenter : IGlassEditorPresenter
    {
        private IGlassEditorView _glassEditor;
        private GlassModel _glass;

        private double _oldWidth, _oldDiameter;

        private readonly string _lessThanZeroMessage;

        public Action CheckData { get; }

        public void ResetFields()
        {
            _glass.Diameter = _oldDiameter;
            _glass.Height = _oldWidth;
        }

        public Result[] UpdateModel(string height, string diameter)
        {
            Result[] results = new Result[2];

            results[0] = _glass.TryConvertToDoubleAndValidate(height, nameof(_glass.Height));
            results[1] = _glass.TryConvertToDoubleAndValidate(diameter, nameof(_glass.Diameter));

            return results;
        }

        public void SetView(IGlassEditorView view)
        {
            _glassEditor = view;
        }

        public void SetDefaultValues(ref string height, ref string diameter)
        {
            if (_glass.Height > 0 )
            {
                height = _glass.Height.ToString();
            }
            
            if (_glass.Diameter > 0 )
            {
                diameter = _glass.Diameter.ToString();
            }
        }

        public GlassEditorPresenter(GlassModel glass)
        {
            _glass = glass;

            _oldWidth = _glass.Height;
            _oldDiameter = _glass.Diameter;

            switch(CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        _lessThanZeroMessage = "{0} must be greater than zero!";

                        break;
                    }
                default:
                    {
                        _lessThanZeroMessage = "{0} должен быть больше нуля!";

                        break;
                    }
            }
        }
    }
}
