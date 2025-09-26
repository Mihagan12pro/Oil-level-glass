using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Interfaces;
using APIv7_gateway.ModelObjects;
using APIv7_gateway.ModelObjects.Chamfers;
using APIv7_gateway.ModelObjects.Extrusions;
using APIv7_gateway.ModelObjects.Holes;
using APIv7_gateway.ModelObjects.Parts;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Structs;

namespace APIv7_gateway.Gateways.Three_D
{
    public class KompasPartGateway : KompasGateway, ISerializableGateway
    {
        private readonly IModelContainer? _modelContainer;
        internal IModelContainer? ModelContainer => _modelContainer;

        public readonly PartObject Part;

        
        public void SetName(KompasFile kompasFile)
        {
            Part.ChangeName(kompasFile.Name);
        }


        public void Save(string? file)
        {
            kompasDocument?.SaveAs(file);
        }


        public void SetMaterial(Material material)
        {
            Part.ChangeMaterial(material);
        }


        public void SetAppearance(Appereance appereance)
        {
            Part.ChangeApperance(appereance);
        }


        public void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges)
        {
            if (kompasDocument == null)
                throw new NullReferenceException();

            kompasDocument.Close(howSave);
        }


        public SketchObject CreateSketch(PlaneObject plane)
        {
            SketchObject sketchObject = new SketchObject(_modelContainer.Sketchs.Add(), plane);
            sketchObject.Update();

            return sketchObject;
        }


        public ChamferByAngleObject CreateChamferByAngle(double distance1, double angle, EdgeObject[] edges)
        {
            ChamferByAngleObject chamfer = new ChamferByAngleObject(ModelContainer.Chamfers.Add()) { Distance1 = distance1, Angle = angle, Edges = edges };
            chamfer.Update();

            return chamfer;
        }


        public SketchObject CreateSketch(FaceObject faceObject)
        {
            SketchObject sketchObject = new SketchObject(_modelContainer.Sketchs.Add(), faceObject);
            sketchObject.Update();

            return sketchObject;
        }


        public BossExtrusionObject CreateExtrusion(SketchObject ?sketch, DistanceParameter depth, DirectionParameter direction)
        {
            if (_modelContainer == null)
                throw new NullReferenceException();

            return new BossExtrusionObject(_modelContainer.Extrusions.Add(ksObj3dTypeEnum.o3d_bossExtrusion)) 
            {
                Sketch = sketch, 

                Depth = depth,

                Direction = direction
            };
        }


        public HoleObject CreateHole(VertexObject vertex, FaceObject face)
        {
            return new HoleObject(_modelContainer.Holes3D.Add()) { Face = face, Vertex = vertex };
        }


        public KompasPartGateway(bool isActive = false)
        {
            if (isActive)
                kompasDocument = kompasApplication?.ActiveDocument;
            else
                kompasDocument = kompasApplication?.Documents.Add(DocumentTypeEnum.ksDocumentPart);

            IPartDocument ?partDocument = (kompasDocument as IPartDocument);

            if (partDocument == null)
                throw new NullReferenceException();

            Part = new PartObject(partDocument.TopPart as Part7Class);

            _modelContainer = Part.ModelContainer;
        }
    }
}
