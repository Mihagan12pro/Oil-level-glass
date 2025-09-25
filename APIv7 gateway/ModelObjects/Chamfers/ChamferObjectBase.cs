using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects.Chamfers
{
    public abstract class ChamferObjectBase : ModelObjectBase
    {
        protected IChamfer chamfer;

        internal override IModelObject? ModelObject => chamfer;

        public required double Distance1 { get => chamfer.Distance1; set => chamfer.Distance1 = value; }

        public required EdgeObject[] Edges
        {
            set
            {
                IEdge[] edges = new IEdge[value.Length];

                for(int i = 0; i < value.Length; i++)
                {
                    edges[i] = (IEdge)value[i].ModelObject;
                }

                chamfer.BaseObjects = edges;
            }
        }

        internal ChamferObjectBase(IChamfer chamfer)
        {
            this.chamfer = chamfer;
        }
    }
}
