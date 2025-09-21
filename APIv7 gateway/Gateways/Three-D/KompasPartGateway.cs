using APIv7_gateway.Enums;
using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Extrusion_params.Types;
using APIv7_gateway.Interfaces;
using APIv7_gateway.ModelObjects;
using APIv7_gateway.ModelObjects.Extrusions;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Structs;
using NativeMethods;
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

                PlaneXOY = new PlaneObject((IPlane3D)base.Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY]);

                PlaneXOZ = new PlaneObject((IPlane3D)base.Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOZ]);

                PlaneYOZ = new PlaneObject((IPlane3D)base.Part.DefaultObject[ksObj3dTypeEnum.o3d_planeYOZ]);
            }
        }


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
            if (Part == null)
                throw new NullReferenceException();

            Part.Name = kompasFile.Name.Naming;

            Part.Marking = kompasFile.Name.Marking;

            Part.Update();
        }


        public void Save(string? file)
        {
            kompasDocument?.SaveAs(file);
        }


        public void SetMaterial(Material material)
        {
            if (Part == null)
                throw new NullReferenceException();

            Part.SetMaterial(material.Tittle, material.Density);

            IHatchParam hatchParam = Part.HatchParam;
            hatchParam.Style = material.HatchStyle;

            Part.Update();
        }


        public void SetAppearance(Appereance appereance)
        {
            if (Part == null)
                throw new NullReferenceException();

            IColorParam7 colorParam = (IColorParam7)Part;


            colorParam.SetAdvancedColor(appereance.Color, appereance.Ambient, appereance.Diffuse, appereance.Specularity, appereance.Shininess, appereance.Transparency, appereance.Emission);

            Part.Update();
        }


        public void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges)
        {
            if (kompasDocument == null)
                throw new NullReferenceException();

            kompasDocument.Close(howSave);
        }


        public SketchObject CreateSketch(PlaneObject plane)
        {
            return new SketchObject(_modelContainer.Sketchs.Add(), plane);
        }


        public SketchObject CreateSketch(FaceObject faceObject)
        {
            return new SketchObject(_modelContainer.Sketchs.Add(), faceObject);
        }


        public BossExtrusionObject CreateExtrusion(SketchObject ?sketch, DepthParameter depth, DirectionParameter direction, ExtrusionTypeParameter extrusionType)
        {
            if (_modelContainer == null)
                throw new NullReferenceException();

            return new BossExtrusionObject(_modelContainer.Extrusions.Add(ksObj3dTypeEnum.o3d_bossExtrusion)) 
            {
                Sketch = sketch, 

                Depth = depth,

                Direction = direction,

                ExtrusionType = extrusionType
            };
        }


        public KompasPartGateway(bool isActive = false)
        {
            if (isActive)
                kompasDocument = kompasApplication?.ActiveDocument;
            else
                kompasDocument = kompasApplication?.Documents.Add(DocumentTypeEnum.ksDocumentPart);
        }
    }
}
