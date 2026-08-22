using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.Presenters.Extensions;
using Shared.Results;
using Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip.HelpStructures;
using Oil_level_glass.UI.Abstractions;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip
{
    internal class RubberStripEditorPresenter 
        : IRubberStripEditorPresenter
    {
        private readonly RubberStripModel _rubberStrip;
        private readonly double _oldInternalDiameter, _oldHeight;
        private IRubberStripEditorView _form;
        
        public Action CheckData { get; }

        public RubberStripDefaultSizes DefaultSizes
        {
            get
            {
                return new RubberStripDefaultSizes(
                    _oldHeight,
                    _rubberStrip.ExternalDiameter,
                    _oldInternalDiameter
                );
            }
        }

        public void ResetFields()
        {
            _rubberStrip.InternalDiameter = _oldInternalDiameter;
            _rubberStrip.Height = _oldHeight;
        }

        public void SetView(IRubberStripEditorView view)
            => _form = view; 

        public RubberStripUpdateResults UpdateModel(RubberStripUpdateData updateData)
        {
            RubberStripUpdateResults updateResults = new RubberStripUpdateResults
            {
                InternalDiameter = _rubberStrip.TryConvertToDoubleAndValidate(updateData.InternalDiameter, nameof(_rubberStrip.InternalDiameter)),

                Height = _rubberStrip.TryConvertToDoubleAndValidate(updateData.Height, nameof(_rubberStrip.Height))
            };

            return updateResults;
        }

        public void SetView(IView view)
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
