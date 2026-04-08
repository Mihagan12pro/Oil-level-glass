using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Wizard3d.Editors.Glass;
using Shared;
using System.Globalization;

namespace Oil_level_glass.UI.Presenters.Glass
{
    internal class GlassEditorPresenter : IGlassEditorPresenter
    {
        private readonly IGlassEditor _glassEditor;
        private readonly GlassModel _glass;

        private readonly double _oldWidth, _oldDiameter;

        public Result UpdateWidth(string width)
        {
            if (double.TryParse(width, out double realWidth) || double.TryParse(
                    width, NumberStyles.AllowDecimalPoint,
                    new CultureInfo("en-US"),
                    out realWidth))
            {
                _glass.Height = realWidth;

                string error = _glass[nameof(_glass.Height)];
                if (error == string.Empty)
                    return new Result(true);

                return new Result(false, error);
            }

            return new Result(false, "Height must be real number!");
        }

        public Result UpdateDiameter(string diameter)
        {
            if (double.TryParse(diameter, out double realDiameter) || double.TryParse(
                   diameter, NumberStyles.AllowDecimalPoint,
                   new CultureInfo("en-US"),
                   out realDiameter))
            {
                _glass.ExternalDiameter = realDiameter;

                string error = _glass[nameof(_glass.ExternalDiameter)];
                if (error == string.Empty)
                    return new Result(true);

                return new Result(false, error);
            }

            return new Result(false, "Diameter must be real number!");
        }

        public void ResetFields()
        {
            _glass.ExternalDiameter = _oldDiameter;
            _glass.Height = _oldWidth;
        }

        public GlassEditorPresenter(IGlassEditor glassEditor)
        {
            _glassEditor = glassEditor;

            _glass = _glassEditor.Model;

            _oldWidth = _glass.Height;
            _oldDiameter = _glass.ExternalDiameter;
        }
    }
}
