using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects.Copiers
{
    public abstract class CopierBase : ModelObjectBase
    {
        public virtual ModelObjectBase[] ModelObjects
        {
            set
            {
                object[] objects = new object[value.Length];

                for(int i = 0; i <  value.Length; i++)
                {
                    IModelObject ?modelObject = value[i].ModelObject;

                    if (modelObject == null)
                        throw new NullReferenceException();

                    objects[i] = modelObject;
                }
            }
        }
    }
}
