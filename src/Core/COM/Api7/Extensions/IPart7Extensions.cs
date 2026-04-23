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
            part.Update();
        }

        public static void SetNaming(this IPart7 part, Name name)
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
    }
}
