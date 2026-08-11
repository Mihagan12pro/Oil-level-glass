using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.Presenters.Extensions;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.RubberStrip
{
    internal class RubberStripEditorPresenter : IRubberStripEditorPresenter
    {
        private readonly RubberStripModel _rubberStrip;
        private readonly double _oldInternalDiameter, _oldHeight;
        private readonly IRubberStripEditorView _form;
        
        public Action CheckData { get; }

        public void ResetFields()
        {
            _rubberStrip.InternalDiameter = _oldInternalDiameter;
            _rubberStrip.Height = _oldHeight;
        }

        public Result UpdateInternalDiameter(string diameter)
            => _rubberStrip.TryConvertToDoubleAndValidate(diameter, nameof(_rubberStrip.InternalDiameter));

        public Result UpdateHeight(string height)
            => _rubberStrip.TryConvertToDoubleAndValidate(height, nameof(_rubberStrip.Height));

        public void SetView(IRubberStripEditorView view)
        {
            throw new NotImplementedException();
        }

        public RubberStripEditorPresenter(
            IRubberStripEditorView form,
            Action checkData)
        {
            _form = form;
            CheckData = checkData;

            _oldInternalDiameter = _rubberStrip.InternalDiameter;
            _oldHeight = _rubberStrip.Height;
        }
    }
}
