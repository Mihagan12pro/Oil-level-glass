using APIv7_gateway.ModelObjects;
using Oil_level_glass_Core.Data.Materials;
using Oil_level_glass_Core.Services;
using APIv7_gateway.Gateways.Two_D;
using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.DrawingObjects;
using KompasAPI7;

namespace Oil_level_glass_Core.Creators.Creators3D.Builders
{
    public record RingBuilder : BaseBuilder
    {
        public double ExternalDiameter { get; set; }

        public double InternalDiameter { get; set; }

        public double RingHeight { get; set; }


        public override void Create()
        {
            KompasPartGateway partGateway = new KompasPartGateway(DocumentManager.GetPartDocument(false));

            SketchObject ?sketch = partGateway.CreateSketch(partGateway.PlaneYOZ);

            Geometry2DGateway geometry2DGateway = new Geometry2DGateway(sketch?.BeginEdit());

            CircleObject internalCircle = geometry2DGateway.AddCircle(InternalDiameter, 0, 0);
            internalCircle.Update();

            CircleObject externalCircle = geometry2DGateway.AddCircle(ExternalDiameter, 0, 0);
            externalCircle.Update();

            Properties.KompasFile.Naming.Name = "Резиновое кольцо";
            Properties.KompasFile.Naming.Marking = "МПСТ.000.000.001";
            Properties.KompasFile.FolderPath = "C:\\";

            sketch?.EndEdit();


            partGateway.Save(Properties?.KompasFile?.FullName);
        }


        public RingBuilder()
        {
            Properties = new Data.ModelProperties.Properties3D.ModelPartProperties() { Material = new Rubber()};
        }
    }
}
