using Kompas6Constants3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Kompas_classes
{
    internal class Ring : KompasDetail
    {
        private double _width;
        private double _diameter1;
        private double _diameter2;

        private SketchShell _sketch1;
        private BossExtrusionShell _extrusion1;
        public override void Build()
        {
            base.Build();

            _sketch1 = Sketch
                (
                    planeXOZ,
                    new List<Entity2D> 
                        {
                            new Circle(new Point(0,0),_diameter1,Entity2D.MainLine),
                            new Circle(new Point(0,0),_diameter2,Entity2D.MainLine)
                        }
                );

            _extrusion1 = BossExtrusion(new List<SketchShell> { _sketch1 }, true, Direction_Type.dtNormal, _width, 0, false);

            Part.SetMaterial("Резина", 1.6);
            Part.SetAdvancedColor(Color.Black.ToArgb());

            Part.Update();

            Document3D.SaveAs(SavePath);
        }


        public Ring(double h, double d2,double d1)
        {
            _diameter1 = d2;
            _diameter2 = d1;
            _width = h/3;
        }
    }
}
