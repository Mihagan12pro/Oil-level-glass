using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;

namespace Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor
{
    internal class ChamferEditorPresenter : IChamferEditorPresenter
    {
        private ChamferModel _chamfer;

        private readonly IChamferEditorView _view;

        public ChamferModel Model
        {
            get
            {
                return _chamfer;
            }
            set
            {
                _chamfer = value;

                if (_chamfer.MaxSide1 > 0)
                {
                    _view.ChamferSide1PlaceHolder = _chamfer.MaxSide1.ToString();
                    _view.ChamferSide2PlaceHolder = _chamfer.MaxSide1.ToString();
                }    

                if (_chamfer.Angle > 0)
                    _view.ChamferAngle = _chamfer.Angle.ToString();

                if (_chamfer.Side1 > 0)
                    _view.ChamferSide1 = _chamfer.Side1.ToString();

                if (_chamfer.Side2 > 0)
                    _view.ChamferSide2 = _chamfer.Side2.ToString();

                _view.ChamferSideAngle = _chamfer.Type == ChamferType.SideAndAngle;

                _view.IsValid = _chamfer.HasErrors == false;
            }
        }

        public void ActivateView()
            => _view.ShowView();

        public void ChangeChamferType(bool isAngleSide)
        {
            if (isAngleSide)
            {
                Model.Type = ChamferType.SideAndAngle;

                return;
            }

            Model.Type = ChamferType.TwoSides;
        }

        public ChamferEditorPresenter(IChamferEditorView view)
        {
            _view = view;

            _view.DataChangingHandler += view_DataChangingHandler;
            _view.AcceptDataChangesHandler += view_AcceptDataChangesHandler;
            _view.ClearDataHandler += view_ClearDataHandler;
            _view.CancelDataChangesHandler += view_CancelDataChangesHandler;
            _view.ChamferTypeChangedHandler += view_ChamferTypeChangedHandler;
        }

        private void view_CancelDataChangesHandler()
        {
            if (Model[nameof(Model.Side1)] == string.Empty)
                _view.ChamferSide1 = Model.Side1.ToString();
            else
                _view.ChamferSide1 = string.Empty;

            if (Model[nameof(Model.Side2)] == string.Empty)
                _view.ChamferSide2 = Model.Side2.ToString();
            else
                _view.ChamferSide2 = string.Empty;

            if (Model[nameof(Model.Angle)] == string.Empty)
                _view.ChamferAngle = Model.Angle.ToString();
            else
                _view.ChamferAngle = string.Empty;
        }

        private void view_ChamferTypeChangedHandler()
        {
            if (_view.ChamferSideAngle)
            {
                Model.Type = ChamferType.SideAndAngle;
                return;
            }

            Model.Type = ChamferType.TwoSides;
        }

        private void view_ClearDataHandler()
        {
            _view.ChamferSide1 = string.Empty;

            if (Model.Type == ChamferType.TwoSides)
            {
                _view.ChamferSide2 = string.Empty;
            }
            else
            {
                _view.ChamferAngle = string.Empty;
            }
        }

        private void view_AcceptDataChangesHandler()
        {
            double.TryParse(_view.ChamferSide1, out double s1);
            Model.Side1 = s1;

            if (Model.Type == ChamferType.TwoSides)
            {
                double.TryParse(_view.ChamferSide2, out double s2);

                Model.Side2 = s2;

                _view.ChamferAngle = Model.Angle.ToString();
            }
            else
            {
                double.TryParse(_view.ChamferAngle, out double alpha);

                Model.Angle = alpha;

                _view.ChamferSide2 = Model.Side2.ToString();
            }
        }

        private void view_DataChangingHandler()
        {
            _view.IsValid = double.TryParse(_view.ChamferSide1, out double s1) &&
                            double.TryParse(_view.ChamferSide2, out double s2) &&
                            double.TryParse(_view.ChamferAngle, out double alpha) &&
                            s1 <= Model.MaxSide1 && s1 > 0 && s2 <= Model.MaxSide2 && s2 > 0 &&
                            alpha > 0 && 
                            alpha < 90;
        }
    }
}
