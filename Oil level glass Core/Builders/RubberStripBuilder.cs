using KompasAPI7;
using Oil_level_glass.Model.Parts;

namespace Oil_level_glass_Core.Builders
{
    public class RubberStripBuilder : BaseBuilder
    {
        public required RubberStripModel RubberStrip { get; set; }

        private ICircle _circle1, _circle2;

        private ISketch _sketch1;

        public override void Build()
        {
            AddSketch1();

            base.Build();
        }

        private void AddSketch1()
        {
            _sketch1 = sketchs.Add();

            _sketch1.Plane = Part.DefaultObject[Kompas6Constants3D.ksObj3dTypeEnum.o3d_planeXOY];
            _sketch1.Update();

            document2D = _sketch1.BeginEdit();

            InitDrawingContainer();

            _circle1 = drawingContainer.Circles.Add();
            _circle1.Xc = 0;
            _circle1.Yc = 0;
            _circle1.Radius = RubberStrip.InternalDiameter * 0.5;
            _circle1.Update();


            _circle2 = drawingContainer.Circles.Add();
            _circle2.Xc = 0;
            _circle2.Yc = 0;
            _circle2.Radius = RubberStrip.ExternalDiameter * 0.5;
            _circle2.Update();
        }

        public RubberStripBuilder(bool createNewDocument) : base(createNewDocument)
        {
            
        }
    }
}
