using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.EditorsData.GlassData;
using Oil_level_glass.Presenters.Extensions;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.Glass
{
    internal class GlassEditorPresenter : IGlassEditorPresenter
    {
        private IGlassEditorView _view;
        private GlassModel _glass;

        private double _oldHeight, _oldDiameter;

        private readonly string _lessThanZeroMessage;

        public GlassDefaultDataValues DefaultSizes
            => new GlassDefaultDataValues(_oldDiameter, _oldHeight);

        public GlassModel Model 
        {
            get => _glass;
            set
            {
                _glass = value;

                if (_glass != null)
                {
                    if (_glass.Diameter > 0)
                        _view.GlassDiameter = _glass.Diameter.ToString();

                    if (_glass.Height > 0)
                        _view.GlassHeight = _glass.Height.ToString();
                }
            }
        }

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

        public GlassUpdateDataResults UpdateModel(GlassUpdateDataPending updateData)
        {
            GlassUpdateDataResults updateResults = new GlassUpdateDataResults()
            {
                Diameter = _glass.TryConvertToDoubleAndValidate(updateData.Diameter, nameof(_glass.Diameter)),

                Height = _glass.TryConvertToDoubleAndValidate(updateData.Height, nameof(_glass.Height))
            };

            return updateResults;
        }

        public void ActivateView()
            => _view.ShowView();

        public GlassEditorPresenter(IGlassEditorView view)
        {
            _view = view;

            _view.GlassDiameterPlaceholder = "40";
            _view.GlassHeightPlaceHolder = "2";

            _view.DataChangingHandler += view_DataChangingHandler;
        }

        private void view_DataChangingHandler()
        {
            throw new NotImplementedException();
        }
    }
}
