using APIv7_gateway.Extrusion_params;

namespace APIv7_gateway.ModelObjects.Extrusions
{
    public abstract class ExtrusionObjectBase : ModelObjectBase
    {
        private DistanceParameter? _depth;
        public required DistanceParameter? Depth
        {
            get { return _depth; }
            set
            {
                if (value == null)
                    throw new NullReferenceException();

                _depth = value;

                _depth.AcceptParameter(ModelObject);
            }
        }


        private DirectionParameter? _direction;
        public required DirectionParameter? Direction
        {
            get { return _direction; }
            set
            {
                if (value == null)
                    throw new NullReferenceException();

                _direction = value;

                _direction.AcceptParameter(ModelObject);
            }
        }


        protected SketchObject? sketch;
        public virtual required SketchObject? Sketch { get => sketch; set => sketch = value; }
    }
}
