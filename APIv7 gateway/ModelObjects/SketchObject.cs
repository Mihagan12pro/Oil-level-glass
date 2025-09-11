using KompasAPI7;
using APIv7_gateway.ModelObjects.Standart.Planes;
using APIv7_gateway.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    internal record SketchObject : ModelObjectBase
    {
        public required PlaneObjectBase Plane { get; init; }


        public void AddGeometrySketch()
        {
            IKompasDocument2D document2D = ((ISketch)modelObject).BeginEdit();

            ((ISketch)modelObject).EndEdit();
        }


        public SketchObject(IModelContainer modelContainer) : base(modelContainer)
        {
            modelObject = modelContainer.Sketchs.Add();
        }
    }
}


