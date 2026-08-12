using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.Presenters.Extensions;
using Shared.Results;
using Oil_level_glass.Presenters.Editors.Entities.RubberStrip.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.Data.Entities.RubberStrip
{
    internal class RubberStripEditorPresenter 
        : IRubberStripEditorPresenter
    {
        private readonly RubberStripModel _rubberStrip;
        private readonly double _oldInternalDiameter, _oldHeight;
        private IRubberStripEditorView _form;
        
        public Action CheckData { get; }

        public RubberStripDefaultSizes DefaultSizes => throw new NotImplementedException();

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
            => _form = view; 

        public Result[] UpdateModel(
            string height,
            string internalDiameter)
        {
            Result[] results = new Result[2];

            results[0] = _rubberStrip.TryConvertToDoubleAndValidate(internalDiameter, nameof(_rubberStrip.InternalDiameter));
            results[1] = _rubberStrip.TryConvertToDoubleAndValidate(height, nameof(_rubberStrip.Height));

            return results;
        }

        public void SetDefaultValues(
            ref string height, 
            ref string externalDiameter,
            ref string internalDiameter)
        {
            throw new NotImplementedException();
        }

        public RubberStripUpdateResults UpdateModel(RubberStripUpdateData updateData)
        {
            throw new NotImplementedException();
        }

        public RubberStripEditorPresenter(RubberStripModel rubberStrip)
        {
            _rubberStrip = rubberStrip;

            _oldInternalDiameter = _rubberStrip.InternalDiameter;
            _oldHeight = _rubberStrip.Height;
        }
    }
}
