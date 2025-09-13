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
        private SketchObject? _sketch1;

        public double InternalDiameter { get; set; }
        public double ExternalDiameter { get; set; }

        public double Height { get; set; }

        public override void Create()
        {
            KompasPartGateway = new KompasPartGateway((IPartDocument)Application.Documents.Add(Kompas6Constants.DocumentTypeEnum.ksDocumentPart));

            SetNamingParameters();

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

            SetMaterialParameters();

            SetColorParameters();

            KompasPartGateway.Save(Properties?.KompasFile.FullName);
        }


        public RingCreator()
        {
            Properties = new ModelPartProperties() { Material = new Rubber() };
           
            Properties.KompasFile.Name.Naming = "Прокладка";
            Properties.KompasFile.Name.Marking = "МПСТ.000.000.001";

            Properties.KompasFile.FolderPath = "C:\\Users\\kargi";
        }
    }
}
