using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public class SketchObject : ModelObjectBase
    {
        private readonly PlaneObject? _plane;

        private readonly FaceObject? _face;

        private readonly ISketch _sketch;

        public override IModelObject? ModelObject => _sketch;

        public IKompasDocument2D SketchEditor => _sketch.BeginEdit();


        public void EndEdit()
        {
            _sketch?.EndEdit();
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
