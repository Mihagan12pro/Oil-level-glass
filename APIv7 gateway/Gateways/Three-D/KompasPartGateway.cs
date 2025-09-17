using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Extrusion_params.Types;
using APIv7_gateway.Interfaces;
using APIv7_gateway.ModelObjects;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using Utils;

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


        internal List<FaceObject> Faces
        {
            get
            {
                if (Part == null)
                    throw new NullReferenceException();

                List<FaceObject> faces = new List<FaceObject>();

                foreach(object obj in ArrayMaster.ObjectToArray(Part.DefaultObject[ksObj3dTypeEnum.o3d_face]))
                {
                    IFace? face = obj as IFace;

                    if (face == null)
                        throw new NullReferenceException();

                    faces.Add(new FaceObject(face));
                }

                return faces;
            }
        }


        public IFace GetPlanarFace(double x, double y, double z)
        {
            foreach(IFace face in Faces)
            {
                IEdge[] ?faceEdges = ArrayMaster.ObjectToArray(face.LimitingEdges) as IEdge[];

                if (faceEdges == null)
                    throw new InvalidDataException();

                foreach(IEdge edge in faceEdges)
                {
                    edge.GetPoint(true, out double x1, out double y1, out double z1);

                    if (x1 == x && y1 == y && z1 == z)
                        return face;
                }
            }

            throw new NullReferenceException();
        }





        public void SetName(string? naming, string ?marking)
        {
            if (Part == null)
                throw new NullReferenceException();

            Part.Name = naming;

            Part.Marking = marking;

            Part.Update();
        }


        public void Save(string? file)
        {
            kompasDocument?.SaveAs(file);
        }


        public void SetMaterial(string? tittle, double density, int hatchStyle)
        {
            if (Part == null)
                throw new NullReferenceException();

            Part.SetMaterial(tittle, density);

            IHatchParam hatchParam = Part.HatchParam;
            hatchParam.Style = hatchStyle;

            Part.Update();
        }


        public void SetAppearance(int color, double ambient, double diffuse, double specularity, double shininess, double transparency, double emission)
        {
            if (Part == null)
                throw new NullReferenceException();

            IColorParam7 colorParam = (IColorParam7)Part;


            colorParam.SetAdvancedColor(color, ambient / 100, diffuse / 100, specularity / 100, shininess / 100, transparency / 100, emission / 100);

            Part.Update();
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
