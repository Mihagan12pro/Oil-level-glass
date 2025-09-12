using APIv7_gateway.Interfaces;
using APIv7_gateway.ModelObjects;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;

namespace APIv7_gateway.Gateways.Three_D
{
    public class KompasPartGateway : Kompas3DGateway, ISerializableGateway
    {
        private IModelContainer? _modelContainer;
        public IModelContainer? ModelContainer => _modelContainer;


        public PlaneObject ?PlaneXOY { get; private set; }
        public PlaneObject ?PlaneXOZ { get; private set; }
        public PlaneObject ?PlaneYOZ { get; private set; }



        public override IPart7? Part
        {
            get => base.Part;
            protected set
            {
                base.Part = value;

                if (base.Part == null)
                    throw new NullReferenceException();

                _modelContainer = base.Part as IModelContainer;

                PlaneXOY = new PlaneObject(base.Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY]);

                PlaneXOZ = new PlaneObject(base.Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOZ]);

                PlaneYOZ = new PlaneObject(base.Part.DefaultObject[ksObj3dTypeEnum.o3d_planeYOZ]);
            }
        }



        public void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges)
        {
            kompasDocument?.Close(howSave);
        }


        public void Save(string? file)
        {
            kompasDocument?.SaveAs(file);
        }


        public SketchObject ?CreateSketch(PlaneObject? plane)
        {
            if (_modelContainer == null)
                throw new NullReferenceException();


            return new SketchObject(_modelContainer.Sketchs.Add()) { Plane = plane};
        }


        public KompasPartGateway(IPartDocument document3D)
        {
            kompasDocument = document3D;

            Part = document3D.TopPart;
        }


        public KompasPartGateway(IPart7 externalPart)
        {
            Part = externalPart;
        }
    }
}
