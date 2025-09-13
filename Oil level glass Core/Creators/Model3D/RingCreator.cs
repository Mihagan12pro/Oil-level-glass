using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Extrusion_params;
using APIv7_gateway.Extrusion_params.Direction;
using APIv7_gateway.Extrusion_params.Types;
using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.Gateways.Two_D;
using APIv7_gateway.ModelObjects;
using KompasAPI7;
using Oil_level_glass_Core.Creators.Model3D.Base;
using Oil_level_glass_Core.Data.Materials;
using Oil_level_glass_Core.Data.ModelProperties.Properties3D;

namespace Oil_level_glass_Core.Creators.Model3D
{
    public record RingCreator : BasePartCreator
    {
        private SketchObject _sketch1;

        public double InternalDiameter { get; set; }
        public double ExternalDiameter { get; set; }

        public double Height { get; set; }

        public override void Create()
        {
            KompasPartGateway = new KompasPartGateway((IPartDocument)application.Documents.Add(Kompas6Constants.DocumentTypeEnum.ksDocumentPart));

            KompasPartGateway.SetName(Properties.KompasFile.Name.Naming, Properties.KompasFile.Name.Marking);

            _sketch1 = KompasPartGateway.CreateSketch(KompasPartGateway.PlaneXOY);
            _sketch1?.Update();

            geometry2DGateway = new Geometry2DGateway(_sketch1?.BeginEdit());

            CircleObject internalCircle = geometry2DGateway.AddCircle(InternalDiameter, 0, 0);
            internalCircle.Update();

            CircleObject externalCircle = geometry2DGateway.AddCircle(ExternalDiameter, 0, 0);
            externalCircle.Update();

            _sketch1?.EndEdit();

            ExtrusionObject extrusion1 = KompasPartGateway.CreateExtrusion(_sketch1, new DepthParameter() { Depth = Height }, new DirectionMiddle(), new ExtrusionBlind());
            extrusion1.Update();

            KompasPartGateway.SetMaterial((Properties as ModelPartProperties)?.Material.Tittle, (Properties as ModelPartProperties).Material.Density, (Properties as ModelPartProperties).Material.HatchStyle);

            KompasPartGateway.SetAppearance((Properties as ModelPartProperties).Appearance.RGB.GetColor(), (Properties as ModelPartProperties).Appearance.Ambient, (Properties as ModelPartProperties).Appearance.Diffuse, 
                (Properties as ModelPartProperties).Appearance.Specularity, 
                (Properties as ModelPartProperties).Appearance.Shininess, (Properties as ModelPartProperties).Appearance.Transparency, (Properties as ModelPartProperties).Appearance.Emission);

            KompasPartGateway.Save(Properties?.KompasFile.FullName);
        }


        public RingCreator()
        {
            (Properties as ModelPartProperties).Material = new Rubber() {Density = 3, Tittle = "Резина" };

            Properties.KompasFile.Name.Naming = "Прокладка";
            Properties.KompasFile.Name.Marking = "МПСТ.000.000.001";

            Properties.KompasFile.FolderPath = "C:\\Users\\kargi";
        }
    }
}
