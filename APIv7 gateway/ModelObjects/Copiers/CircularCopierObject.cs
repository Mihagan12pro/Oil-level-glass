using KompasAPI7;

namespace APIv7_gateway.ModelObjects.Copiers
{
    public class CircularCopierObject : CopierBase
    {
        private ICircularPattern _circularCopier;

        internal override IModelObject? ModelObject => _circularCopier;

        public int RadianCount 
        {
            get => _circularCopier.Count1;
            set
            {
                _circularCopier.Count1 = value;

                Update();
            }
        }

        public int RingCount 
        {
            get => _circularCopier.Count2; 
            set
            {
                _circularCopier.Count2 = value;

                Update();
            }
        }

        public double RadianStep 
        {
            get => _circularCopier.Step1; 
            set
            {
                _circularCopier.Step1 = value;

                Update();
            }
        }

        public double CircularStep
        {
            get => _circularCopier.Step2;
            set
            {
                _circularCopier.Step2 = value;

                Update();
            }
        }

        public required Axis3DObject Axis { get; set; }

        public required override ModelObjectBase[] ModelObjects
        {
            set
            {
                object[] objects = new object[value.Length];

                for (int i = 0; i < value.Length; i++)
                {
                    IModelObject? modelObject = value[i].ModelObject;

                    if (modelObject == null)
                        throw new NullReferenceException();

                    objects[i] = modelObject;
                }

                _circularCopier.InitialObjects = objects;

                Update();
            }
        }

        internal CircularCopierObject(ICircularPattern copier)
        {
            _circularCopier = copier;

            CircularStep = 360;
        }
    }
}
