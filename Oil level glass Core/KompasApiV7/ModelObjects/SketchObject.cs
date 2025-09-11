using KompasAPI7;
using Oil_level_glass_Core.KompasApiV7.ModelObjects.Standart.Planes;
using Oil_level_glass_Core.KompasApiV7.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.KompasApiV7.ModelObjects
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


