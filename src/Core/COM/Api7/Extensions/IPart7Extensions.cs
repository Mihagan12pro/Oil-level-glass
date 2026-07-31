using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.Core.COM.Api7.Extensions
{
    internal static class IPart7Extensions
    {
        public static void SetMaterial(this IPart7 part, Material material)
        {
            part.SetMaterial(material.Title, material.Density);

            IHatchParam hatchParam = part.HatchParam;
            hatchParam.Style = material.HatchStyle;

            part.Update();
        }

        public static void SetNaming(this IPart7 part, T name)
        {
            part.Name = name.Naming;
            part.Marking = name.Marking;

            part.Update();
        }

        public static void SetAdavancedColor(this IPart7 part, Appearance appearance)
        {
            IModelContainer modelContainer = (IModelContainer)part;

            IColorParam7 colorParameter = (IColorParam7)modelContainer;
            colorParameter.SetAdvancedColor(
                appearance.Color.Color,
                appearance.Ambient,
                appearance.Diffuse,
                appearance.Specularity,
                appearance.Shininess,
                appearance.Transparency,
                appearance.Emission);

            part.Update();
        }

        public static IFace GetFaceByPoint(this IPart7 part, double x, double y, double z, Func<IFace, bool> faceFunc)
        {
            object facesObj = part.SelectByPoint(((IModelContainer)part).Objects[Obj3dType.o3d_face], x, y, z);

            if (facesObj is object[] faces)
            {
                foreach (var faceObj in faces)
                {
                    if (faceObj is IFace face && faceFunc(face))
                    {
                        return face;
                    }
                }
            }

            return null;
        }

        public static IEdge GetEdgeByPoint(this IPart7 part, double x, double y, double z)
        {
            var edgesObj = part.SelectByPoint(((IModelContainer)part).Objects[Obj3dType.o3d_edge], x, y, z);

            if (edgesObj is object[] edges)
            {
                return (IEdge)edges[0];
            }

            return null;
        }
    }
}
