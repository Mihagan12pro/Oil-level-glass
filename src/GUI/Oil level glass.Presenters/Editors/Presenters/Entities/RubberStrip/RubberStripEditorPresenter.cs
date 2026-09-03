using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;

namespace Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip
{
    internal class RubberStripEditorPresenter 
        : IRubberStripEditorPresenter
    {
        public RubberStripModel Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;

                if (_model.Height > 0)
                    _view.RubberStripHeight = _model.Height.ToString();

                if (_model.ExternalDiameter > 0)
                {
                    _view.RubberStripExternalDiameter = _model.ExternalDiameter.ToString();
                    _view.RubberStripInternalDiameterPlaceHolder = (Math.Round(_model.ExternalDiameter / 1.5, 3)).ToString();
                }

                if (_model.InternalDiameter > 0)
                    _view.RubberStripInternalDiameter = _model.InternalDiameter.ToString();
            }
        }

        public void ActivateView()
            => _view.ShowView();

        public RubberStripEditorPresenter(IRubberStripEditorView view)
        {
            _view = view;

            _view.RubberStripHeightPlaceHolder = "2";

            _view.ClearDataHandler += view_ClearDataHandler;
            _view.DataChangingHandler += view_DataChangingHandler;
            _view.AcceptDataChangesHandler += view_AcceptDataChangesHandler;
            _view.CancelDataChangesHandler += view_CancelDataChangesHandler;
        }

        private void view_CancelDataChangesHandler()
        {
            if (Model.Height > 0)
            {
                _view.RubberStripHeight = Model.Height.ToString();
            }
            else
            {
                _view.RubberStripHeight = "";
            }

            if (Model.ExternalDiameter > 0)
            {
                _view.RubberStripExternalDiameter = Model.ExternalDiameter.ToString();
            }
            else
            {
                _view.RubberStripExternalDiameter = "";
            }

            if (Model.InternalDiameter > 0)
            {
                _view.RubberStripInternalDiameter = Model.InternalDiameter.ToString();
            }
            else
            {
                _view.RubberStripInternalDiameter = "";
            }
        }

        private void view_AcceptDataChangesHandler()
        {
            Model.Height = double.Parse(_view.RubberStripHeight);
            Model.ExternalDiameter = double.Parse(_view.RubberStripExternalDiameter);
            Model.InternalDiameter = double.Parse(_view.RubberStripInternalDiameter);
        }

        private void view_DataChangingHandler()
        {
            _view.IsValid = double.TryParse(_view.RubberStripExternalDiameter, out double d1)
                && double.TryParse(_view.RubberStripInternalDiameter, out double d2)
                && double.TryParse(_view.RubberStripHeight, out double h)
                && h > 0 && d1 > d2 && d2 > 0;
        }

        private void view_ClearDataHandler()
        {
            _view.RubberStripInternalDiameter = "";
            _view.RubberStripExternalDiameter = "";
            _view.RubberStripHeight = "";
        }

        private RubberStripModel _model;

        private readonly IRubberStripEditorView _view;
    }
}
