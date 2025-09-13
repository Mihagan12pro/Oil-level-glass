using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Extrusion_params.Direction;
using APIv7_gateway.Extrusion_params.Types;
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


        public void Save(string? file)
        {
            kompasDocument?.SaveAs(file);
        }

        public void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges)
        {
            if (kompasDocument == null)
                throw new NullReferenceException();

            kompasDocument.Close(howSave);
        }


        public SketchObject CreateSketch(PlaneObject? plane)
        {
            if (_modelContainer == null)
                throw new NullReferenceException();


            return new SketchObject(_modelContainer.Sketchs.Add()) { Plane = plane};
        }


        public ExtrusionObject CreateExtrusion(SketchObject ?sketch, DepthParameter depth, DirectionParameter direction, ExtrusionTypeParameter extrusionType)
        {
            if (_modelContainer == null)
                throw new NullReferenceException();

            return new ExtrusionObject(_modelContainer.Extrusions.Add(ksObj3dTypeEnum.o3d_bossExtrusion)) 
            {
                Sketch = sketch, 

                Depth = depth,

                Direction = direction,

                ExtrusionType = extrusionType
            };
        }


        public KompasPartGateway(IPartDocument document3D)
        {
            kompasDocument = document3D;

            Part = document3D.TopPart;
        }
    }
}
