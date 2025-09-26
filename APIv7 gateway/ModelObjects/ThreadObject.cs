using KompasAPI7;

namespace APIv7_gateway.ModelObjects
{
    public class ThreadObject : ModelObjectBase
    {
        private readonly IThreadsParameters _threadParameters;

        private readonly IThread _thread;


        public bool IsAutoLength
        {
            get
            {
                return _thread.AutoLenght;
            }
            set
            {
                _thread.AutoLenght = value;
            }
        }


        public bool IsAutoDiameter
        {
            get
            {
                return _thread.AutoDiameter;
            }
            set
            {
                _thread.AutoDiameter = value;

                Update();
            }
        }


        public double Length
        {
            get
            {
                return _thread.Lenght;
            }
            set
            {
                _thread.Lenght = value;

                Update();
            }
        }


        public required double Pitch
        {
            get
            {
                return _threadParameters.Pitch;
            }
            set
            {
                _threadParameters.Pitch = value;

                Update();
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

                Update();
            }
        }

        internal override IModelObject? ModelObject => _thread;


        internal ThreadObject(IThread thread)
        {
            _thread = thread;

            _threadParameters = (IThreadsParameters)_thread;
        }
    }
}
