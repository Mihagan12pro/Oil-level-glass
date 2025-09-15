using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public record ThreadObject : ModelObjectBase
    {
        public required double Pitch
        {
            get
            {
                if (_threadParameters == null)
                    throw new NullReferenceException();

                return _threadParameters.Pitch;
            }
            set
            {

                if (_threadParameters == null)
                    throw new NullReferenceException();

                _threadParameters.Pitch = value;
            }
        }


        public required double Diameter
        {
            get
            {
                if (_threadParameters == null)
                    throw new NullReferenceException();

                return _threadParameters.Diameter;
            }
            set
            {

                if (_threadParameters == null)
                    throw new NullReferenceException();

                _threadParameters.Diameter = value;
            }
        }


        private IThreadsParameters? _threadParameters;

        internal ThreadObject(IThread thread)
        {
            thread.AutoLenght = true;

            _threadParameters = thread as IThreadsParameters;

            modelObject = thread;
        }
    }
}
