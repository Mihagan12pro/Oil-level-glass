using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.KompasApiV7.ModelObjects.Standart.Planes
{
    internal sealed record PlaneZOY : PlaneObjectBase
    {
        public PlaneZOY(IModelContainer modelContainer) : base(modelContainer)
        {
            modelObject = ((IPart7)modelContainer).DefaultObject[Kompas6Constants3D.ksObj3dTypeEnum.o3d_planeYOZ];
        }
    }
}
