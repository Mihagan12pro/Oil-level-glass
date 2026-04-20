using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Shared;
using Oil_level_glass.Presenters.Extensions;

namespace Oil_level_glass.Presenters.Editors.RubberStrip
{
    internal class RubberStripEditorPresenter : IRubberStripEditorPresenter
    {
        private readonly RubberStripModel _rubberStrip;
        private readonly double _oldInternalDiameter;
        private readonly IRubberStripEditorForm _form;
        
        public Action CheckData { get; }

        public void ResetFields()
        {
            _rubberStrip.InternalDiameter = _oldInternalDiameter;
        }

        public Result UpdateInternalDiameter(string diameter)
        {
            if (diameter.TryConvertToDouble(out double realDiameter))
            {
                _rubberStrip.InternalDiameter = realDiameter;

                string error = _rubberStrip[nameof(_rubberStrip.InternalDiameter)];
                if (error == string.Empty)
                    return new Result(true);

                return new Result(false, error);
            }

            return new Result(false, "Internal diameter must be real number!");
        }

        public RubberStripEditorPresenter(
            IRubberStripEditorForm form,
            Action checkData)
        {
            _form = form;
            CheckData = checkData;
            _rubberStrip = _form.Model;

            _oldInternalDiameter = _rubberStrip.InternalDiameter;
        }
    }
}
