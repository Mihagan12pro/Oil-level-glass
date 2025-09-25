using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Enums;
using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public class SketchObject : ModelObjectBase
    {
        private readonly PlaneObject? _plane;

        private readonly FaceObject? _face;

        private readonly ISketch _sketch;

        internal override IModelObject? ModelObject => _sketch;

        private IKompasDocument2D? _kompasDocument2D;

        private IViewsAndLayersManager? _viewsAndLayersManager;

        private IDrawingContainer? _geometryContainer;

        private IView? _view;

        public void BeginEdit()
        {
            _kompasDocument2D = _sketch.BeginEdit();

            _viewsAndLayersManager = _kompasDocument2D?.ViewsAndLayersManager;

            _view = _viewsAndLayersManager?.Views.ActiveView;

            _geometryContainer = _view as IDrawingContainer;
        }

        public void EndEdit()
        {
            _sketch.EndEdit();
        }

        public CircleObject AddCircle(double diameter, double xc, double yc, CurveStyles style = CurveStyles.Normal)
        {
            if (_kompasDocument2D == null)
                BeginEdit();

            if (_geometryContainer == null)
                throw new NullReferenceException();

            CircleObject circle = new CircleObject(_geometryContainer.Circles.Add())
            {
                Diameter = diameter,
                Xc = xc,
                Yc = yc,
                Style = style
            };
            circle.Update();

            return circle;
        }

        public PointObject AddPoint(double x, double y, CurveStyles style = CurveStyles.Normal)
        {
            if (_kompasDocument2D == null)
                BeginEdit();

            if (_geometryContainer == null)
                throw new NullReferenceException();


            PointObject point = new PointObject(_geometryContainer.Points.Add())
            {
                X = x,

                Y = y,

                Style = style
            };

            point.Update();

            return point;
        }

        internal SketchObject(ISketch sketch, PlaneObject plane)
        {
            _sketch = sketch;
            _plane = plane;

            _sketch.Plane = plane.ModelObject;
        }

        internal SketchObject(ISketch sketch, FaceObject face)
        {
            _sketch = sketch;
            _face = face;

            _sketch.Plane = face.ModelObject;
        }
    }
}
