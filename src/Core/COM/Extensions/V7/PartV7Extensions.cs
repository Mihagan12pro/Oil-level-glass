using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.COM.Extensions.V7
{
    internal static class PartV7Extensions
    {
        public static IPlane3D GetPlaneXOY(this IPart7 part)
        {
            return (IPlane3D)part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY];
        }
        public static IPlane3D GetPlaneXOZ(this IPart7 part)
        {
            return (IPlane3D)part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOZ];
        }

        public static IPlane3D GetPlaneYOZ(this IPart7 part)
        {
            return (IPlane3D)part.DefaultObject[ksObj3dTypeEnum.o3d_planeYOZ];
        }

        public static void SetMaterial(this IPart7 part, Material material)
        {
            part.SetMaterial(material.Title, material.Density);

            part.Update();
        }

        public static void SetName(this IPart7 part, Name name)
        {
            part.Name = name.Naming;
            part.Marking = name.Marking;

            part.Update();
        }

        public static void SetFileName(this IPart7 part, KompasFile file)
        {
            part.FileName = file.FullName;

            part.Update();
        }

        public static void SetAppearance(this IPart7 part, Appereance appearance)
        {
            IModelContainer modelContainer = (IModelContainer)part;

            IColorParam7 colorParameter = (IColorParam7)modelContainer;

            colorParameter.SetAdvancedColor(
                appearance.Color,

                appearance.Ambient,

                appearance.Diffuse,

                appearance.Specularity,

                appearance.Shininess,

                appearance.Transparency,

                appearance.Emission
            );

            part.Update();
        }
    }
}
