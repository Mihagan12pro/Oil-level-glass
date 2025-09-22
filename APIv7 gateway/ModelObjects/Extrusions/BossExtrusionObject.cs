using KompasAPI7;

namespace APIv7_gateway.ModelObjects.Extrusions
{
    public class BossExtrusionObject : ExtrusionObjectBase
    {
        private readonly IExtrusion _bossExtrusion;

        internal override IModelObject? ModelObject => _bossExtrusion;

        public override required SketchObject? Sketch 
        {
            get => base.Sketch; 
            set
            {
                base.Sketch = value;

                Sketch ?sk = value?.ModelObject as Sketch;

                _bossExtrusion.Sketch = sk;
            }
        }

        internal BossExtrusionObject(IExtrusion extrusion)
        {
            if (extrusion is ICutExtrusion)
                throw new InvalidDataException("Only for boss extrusion!");

            _bossExtrusion = extrusion;
        }
    }
}
