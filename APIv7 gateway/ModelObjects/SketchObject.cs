using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public class SketchObject : ModelObjectBase
    {
        private readonly PlaneObject? _plane;

        private readonly FaceObject? _face;

        private readonly ISketch _sketch;

        internal override IModelObject? ModelObject => _sketch;

        public SketchEditor SketchEditor
        {
            get
            {
                return new SketchEditor(_sketch);
            }
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
