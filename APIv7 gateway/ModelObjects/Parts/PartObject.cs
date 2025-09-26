using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Enums;
using Kompas6Constants3D;
using KompasAPI7;
using KompasData.Materials;
using KompasData.Structs;
using Utils;

namespace APIv7_gateway.ModelObjects.Parts
{
    public class PartObject : ModelObjectBase
    {
        protected readonly IPart7 part;

        internal override IModelObject? ModelObject => part;

        internal string FullPath => part.FileName;

        public readonly PlaneObject PlaneXOY, PlaneYOZ, PlaneXOZ;

        private readonly IModelContainer? _modelContainer;
        internal IModelContainer? ModelContainer => _modelContainer;

        internal void ChangeName(Name name)
        {
            part.Name = name.Naming;

            part.Marking = name.Marking;

            part.Update();
        }


        public VertexObject GetVertexByPoint(double x = 0, double y = 0, double z = 0)
        {
            object[] vertices = (object[])ArrayMaster.ObjectToArray(ModelContainer.Objects[ksObj3dTypeEnum.o3d_vertex]);

            IVertex? vertex = null;

            foreach (object obj in vertices)
            {
                IVertex vert = (IVertex)obj;

                vert.GetPoint(out double x1, out double y1, out double z1);

                if (x1 == x && y1 == y && z1 == z)
                {
                    vertex = vert;

                    break;
                }
            }

            if (vertex == null)
                throw new Exception($"Vertex with coordinates x = {x}, y = {y}, z = {z} has not been found!");

            return new VertexObject(vertex);
        }


        public EdgeObject GetEdgeByPoint(double x = 0, double y = 0, double z = 0)
        {
            object[] modelEdges = (object[])ArrayMaster.ObjectToArray(ModelContainer.Objects[ksObj3dTypeEnum.o3d_edge]);

            IEdge? modelEdge = null;

            foreach (object obj in modelEdges)
            {
                IEdge edge = (IEdge)obj;

                edge.GetPoint(true, out double x1, out double y1, out double z1);

                if (x1 == x && y1 == y && z1 == z)
                {
                    modelEdge = edge;

                    break;
                }
            }

            if (modelEdge == null)
                throw new Exception($"Edge that contains point with coordinates x = {x}, y = {y}, z = {z} has not been found!");

            return new EdgeObject(modelEdge);
        }


        public FaceObject GetFaceByPoint(FaceTypes faceType = FaceTypes.Planar, double x = 0, double y = 0, double z = 0)
        {
            if (ModelContainer == null)
                throw new NullReferenceException();

            object[] modelFaces = (object[])ArrayMaster.ObjectToArray(ModelContainer.Objects[ksObj3dTypeEnum.o3d_face]);

            if (modelFaces == null)
                throw new NullReferenceException();

            List<IFace> specificFaces = new List<IFace>();

            foreach (object obj in modelFaces)
            {
                IFace face = (IFace)obj;

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

            foreach (IFace face in specificFaces)
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


        internal void ChangeApperance(Appereance appereance)
        {
            IColorParam7 color = (IColorParam7)part;

            color.SetAdvancedColor(appereance.Color, appereance.Ambient, appereance.Diffuse, appereance.Specularity, appereance.Shininess, appereance.Transparency, appereance.Emission);

            part.Update();
        }


        internal void ChangeMaterial(Material material)
        {
            part.SetMaterial(material.Tittle, material.Density);

            IHatchParam hatchParam = part.HatchParam;

            hatchParam.Style = material.HatchStyle;

            part.Update();
        }



        internal PartObject(Part7Class part)
        {
            this.part = part;

            _modelContainer = part as IModelContainer;

            PlaneXOY = new PlaneObject((IPlane3D)part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY]);

            PlaneYOZ = new PlaneObject((IPlane3D)part.DefaultObject[ksObj3dTypeEnum.o3d_planeYOZ]);

            PlaneXOZ = new PlaneObject((IPlane3D)part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOZ]);
        }
    }
}
