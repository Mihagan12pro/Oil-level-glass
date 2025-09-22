using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public class PlaneObject : ModelObjectBase
    {
        private readonly IPlane3D _plane;

        internal override IModelObject? ModelObject => _plane;


        internal PlaneObject(IPlane3D plane)
        {
            _plane = plane;
        }
    }
}
