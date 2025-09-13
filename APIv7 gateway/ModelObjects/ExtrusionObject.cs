using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Extrusion_params.Types;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public record ExtrusionObject : ModelObjectBase
    {
        private SketchObject _sketch;
        public required SketchObject Sketch
        {
            get { return _sketch; }
            set
            {
                _sketch = value;

                IExtrusion? extrusion = modelObject as IExtrusion;

                if (extrusion == null)
                    throw new InvalidDataException();

                extrusion.Sketch = _sketch.ModelObject as Sketch;
            }
        }


        private DepthParameter _depth;
        public required DepthParameter Depth
        {
            get { return _depth; }
            set
            {
                _depth = value;

                _depth.AcceptParameter(ModelObject);  
            }
        }


        private DirectionParameter _direction;
        public required DirectionParameter Direction
        {
            get { return _direction; }
            set
            {
                _direction = value;

                _direction.AcceptParameter(ModelObject);
            }
        }


        private ExtrusionTypeParameter _extrusionType;
        public required ExtrusionTypeParameter ExtrusionType
        {
            get { return _extrusionType; }
            set
            {
                _extrusionType = value;

                _extrusionType.AcceptParameter(ModelObject);
            }
        }

        internal ExtrusionObject(IExtrusion extrusion)
        {
            modelObject = extrusion;
        }
    }
}
