using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects.Standart.Planes
{
    internal record PlaneZOX : PlaneObjectBase
    {
        public PlaneZOX(IModelContainer modelContainer) : base(modelContainer)
        {
            modelObject = ((IPart7)modelContainer).DefaultObject[Kompas6Constants3D.ksObj3dTypeEnum.o3d_planeXOZ];
        }
    }
}
