using APIv7_gateway.Enums;
using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Interfaces;
using APIv7_gateway.ModelObjects;
using APIv7_gateway.ModelObjects.Extrusions;
using APIv7_gateway.ModelObjects.Parts;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Structs;
using Utils;

namespace APIv7_gateway.Gateways.Three_D
{
    public class KompasPartGateway : KompasGateway, ISerializableGateway
    {
        private IModelContainer? _modelContainer;
        internal IModelContainer? ModelContainer => _modelContainer;

        private readonly PartObject _part;

        public FaceObject GetFaceByPoint(FaceTypes faceType = FaceTypes.Planar, double x = 0, double y = 0, double z = 0)
        {
            if (ModelContainer == null)
                throw new NullReferenceException();

            IFace[]? modelFaces = ArrayMaster.ObjectToArray(ModelContainer.Objects[ksObj3dTypeEnum.o3d_face]) as IFace[];

            if (modelFaces == null)
                throw new NullReferenceException();

            List<IFace> specificFaces = new List<IFace>();

            foreach (IFace face in modelFaces)
            {
                switch (faceType)
                {
                    case FaceTypes.Planar:
                        if (face.IsPlanar)
                            specificFaces.Add(face);
                        break;

                    case FaceTypes.Cylindric:
                        if (face.IsCylinder)
                            specificFaces.Add(face);
                        break;
                }
            }

            if (specificFaces.Count == 0)
                throw new Exception("Faces have not been found!");

            FaceObject? specificFaceObject = null;

            foreach(IFace face in specificFaces)
            {
                FaceObject faceObject = new FaceObject(face);

                try
                {
                    EdgeObject edgeObject = faceObject.Edges[(x, y, z)];

                    specificFaceObject = new FaceObject(face);
                }
                catch
                {
                    Console.WriteLine("Не та грань!");
                }
            }

            if (specificFaceObject == null)
                throw new Exception("Face has not been found!");

            return specificFaceObject;
        }

        
        public void SetName(KompasFile kompasFile)
        {
            _part.ChangeName(kompasFile.Name);
        }


        public void Save(string? file)
        {
            kompasDocument?.SaveAs(file);
        }


        public void SetMaterial(Material material)
        {
            _part.ChangeMaterial(material);
        }


        public void SetAppearance(Appereance appereance)
        {
            _part.ChangeApperance(appereance);
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


        public KompasPartGateway(bool isActive = false)
        {
            if (isActive)
                kompasDocument = kompasApplication?.ActiveDocument;
            else
                kompasDocument = kompasApplication?.Documents.Add(DocumentTypeEnum.ksDocumentPart);

            IPartDocument ?partDocument = (kompasDocument as IPartDocument);

            if (partDocument == null)
                throw new NullReferenceException();

            _part = new PartObject(partDocument.TopPart);
        }
    }
}
