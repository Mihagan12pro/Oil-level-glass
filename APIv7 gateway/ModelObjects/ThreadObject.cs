using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public class ThreadObject : ModelObjectBase
    {
        private readonly IThreadsParameters _threadParameters;

        private readonly IThread _thread;

        public required double Pitch
        {
            get
            {
                return _threadParameters.Pitch;
            }
            set
            {

                _threadParameters.Pitch = value;
            }
        }


        public required double Diameter
        {
            get
            {
                return _threadParameters.Diameter;
            }
            set
            {
                _threadParameters.Diameter = value;
            }
        }

        public override IModelObject? ModelObject => _thread;


        internal ThreadObject(IThread thread)
        {
            thread.AutoLenght = true;

            _thread = thread;

            _threadParameters = (IThreadsParameters)_thread;
        }
    }
}
