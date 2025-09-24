using KompasAPI7;
using KompasData.Materials;
using KompasData.Structs;

namespace APIv7_gateway.ModelObjects.Parts
{
    public class PartObject : ModelObjectBase
    {
        protected readonly IPart7 part;

        internal override IModelObject? ModelObject => part;

        internal string FullPath => part.FileName;


        internal void ChangeName(Name name)
        {
            part.Name = name.Naming;

            part.Marking = name.Marking;

            part.Update();
        }


        internal void ChangeMaterial(Material material)
        {
            part.SetMaterial(material.Tittle, material.Density);

            IHatchParam hatchParam = part.HatchParam;

            hatchParam.Style = material.HatchStyle;

            part.Update();
        }


        internal void ChangeApperance(Appereance appereance)
        {
            IColorParam7 color = (IColorParam7)part;

            color.SetAdvancedColor(appereance.Color, appereance.Ambient, appereance.Diffuse, appereance.Specularity, appereance.Shininess, appereance.Transparency, appereance.Emission);

            part.Update();
        }


        internal PartObject(IPart7 part)
        {
            this.part = part;
        }
    }
}
