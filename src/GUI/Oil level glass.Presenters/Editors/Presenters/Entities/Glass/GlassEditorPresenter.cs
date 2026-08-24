using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.Glass;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.Glass
{
    internal class GlassEditorPresenter : IGlassEditorPresenter
    {
        private IGlassEditorView _view;
        private GlassModel _glass;

        private double _oldHeight, _oldDiameter;

        public GlassModel Model 
        {
            get => _glass;
            set
            {
                _glass = value;

                if (_glass != null)
                {
                    if (_glass.Diameter > 0)
                    {
                        _view.GlassDiameter = _glass.Diameter.ToString();
                    }

                    if (_glass.Height > 0)
                    {
                        _view.GlassHeight = _glass.Height.ToString();
                    }
                }
            }
        }

        public void ActivateView()
            => _view.ShowView();

        public GlassEditorPresenter(IGlassEditorView view)
        {
            _view = view;

            _view.GlassDiameterPlaceholder = "40";
            _view.GlassHeightPlaceHolder = "2";

            _view.DataChangingHandler += view_DataChangingHandler;
            _view.CancelDataChangesHandler += view_CancelDataChangesHandler;
            _view.ClearDataHandler += view_ClearDataHandler;
            _view.AcceptDataChangesHandler += view_AcceptDataChangesHandler;
        }

        private void view_AcceptDataChangesHandler()
        {
            Model.Height = double.Parse(_view.GlassHeight);
            Model.Diameter = double.Parse(_view.GlassDiameter);
        }

        private void view_ClearDataHandler()
        {
            _view.GlassDiameter = "";
            _view.GlassHeight = "";
        }

        private void view_CancelDataChangesHandler()
        {
            if (Model.Height > 0)
            {
                _view.GlassHeight = Model.Height.ToString();
            }
            else
            {
                _view.GlassHeight = "";
            }

            if (Model.Diameter > 0)
            {
                _view.GlassDiameter = Model.Diameter.ToString();
            }
            else
            {
                _view.GlassDiameter = "";
            }
        }

        private void view_DataChangingHandler()
        {
            _view.IsValid = double.TryParse(_view.GlassDiameter, out double d) &&
                    double.TryParse(_view.GlassHeight, out double h) &&
                    d > 0 && h > 0;
        }
    }
}
