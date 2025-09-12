using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public record SketchObject : ModelObjectBase
    {
        private PlaneObject? _plane;
        public required PlaneObject? Plane
        {
            get => _plane;

            set
            {
                _plane = value;

                ISketch ?sketch = (modelObject as ISketch);
                if (sketch == null)
                {
                    throw new NullReferenceException();
                }

                sketch.Plane = value?.ModelObject;
                sketch.Update();
            }
        }


        public IKompasDocument2D BeginEdit()
        {
            ISketch ?sketch = (modelObject as ISketch);

            if (sketch == null)
                throw new NullReferenceException();

            return sketch.BeginEdit();
        }


        public void EndEdit()
        {
            (modelObject as ISketch)?.EndEdit();
        }


        internal SketchObject(ISketch sketch)
        {
            modelObject = sketch as ISketch;
        }
    }
}
