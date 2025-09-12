using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public record PlaneObject : ModelObjectBase
    {
        internal PlaneObject(IModelObject plane)
        {
            if (!(plane is IPlane3D))
                throw new InvalidDataException();


            modelObject = plane;
        }
    }
}
