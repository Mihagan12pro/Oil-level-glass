using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Extrusion_params.Types;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects.Extrusions
{
    public abstract class ExtrusionObjectBase : ModelObjectBase
    {
        private DepthParameter? _depth;
        public required DepthParameter? Depth
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


        private ExtrusionTypeParameter? _extrusionType;
        public required ExtrusionTypeParameter? ExtrusionType
        {
            get { return _extrusionType; }
            set
            {
                if (value == null)
                    throw new NullReferenceException();

                _extrusionType = value;

                _extrusionType.AcceptParameter(ModelObject);
            }
        }


        protected SketchObject? sketch;
        public virtual required SketchObject? Sketch { get => sketch; set => sketch = value; }
    }
}
