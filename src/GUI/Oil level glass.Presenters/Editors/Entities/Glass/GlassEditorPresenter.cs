using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Entities.Glass.HelpStructures;
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

        private double _oldHeight, _oldDiameter;

        private readonly string _lessThanZeroMessage;

        public Action CheckData { get; }

        public GlassDefaultSizes DefaultSizes
            => new GlassDefaultSizes(_oldDiameter, _oldHeight);

        public void ResetFields()
        {
            _glass.Diameter = _oldDiameter;
            _glass.Height = _oldHeight;
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

        public GlassUpdateResults UpdateModel(GlassUpdateData updateData)
        {
            GlassUpdateResults updateResults = new GlassUpdateResults()
            {
                Diameter = _glass.TryConvertToDoubleAndValidate(updateData.Diameter, nameof(_glass.Diameter)),

                Height = _glass.TryConvertToDoubleAndValidate(updateData.Height, nameof(_glass.Height))
            };

            return updateResults;
        }

        public GlassEditorPresenter(GlassModel glass)
        {
            _glass = glass;

            _oldHeight = _glass.Height;
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
