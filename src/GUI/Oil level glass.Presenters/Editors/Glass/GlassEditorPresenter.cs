using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Shared.Results;
using System.Globalization;

namespace Oil_level_glass.UI.Presenters.Editors.Glass
{
    internal class GlassEditorPresenter : IGlassEditorPresenter
    {
        private readonly IGlassEditorForm _glassEditor;
        private readonly GlassModel _glass;

        private readonly double _oldWidth, _oldDiameter;

        public Action CheckData { get; }

        public Result UpdateHeight(string height)
            => _glass.TryConvertToDoubleAndValidate(height, nameof(_glass.Height));

        public Result UpdateDiameter(string diameter)
            => _glass.TryConvertToDoubleAndValidate(diameter, nameof(_glass.Diameter));

        public void ResetFields()
        {
            _glass.Diameter = _oldDiameter;
            _glass.Height = _oldWidth;
        }

        internal GlassEditorPresenter(IGlassEditorForm glassEditor, Action checkData)
        {
            _glassEditor = glassEditor;

            _glass = _glassEditor.Model;

            _oldWidth = _glass.Height;
            _oldDiameter = _glass.Diameter;
            CheckData = checkData;
        }
    }
}
