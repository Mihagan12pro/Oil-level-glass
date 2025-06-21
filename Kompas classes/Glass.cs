using Kompas6Constants3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Kompas_classes
{
    internal class Glass : KompasDetail
    {
        private double _width;
        private double _diameter;

        private SketchShell _sketch1;
        private BossExtrusionShell _extrusion1;

        public override void Build()
        {
            base.Build();

            Part.SetAdvancedColor(Color.Gray.ToArgb(),-47,-47,-47,-47,-60,-47);

            _sketch1 = Sketch(planeXOZ,new List<Entity2D> { new Circle(new Point(0,0),_diameter,Entity2D.MainLine)});
            _extrusion1 = BossExtrusion(new List<SketchShell> { _sketch1},true,Direction_Type.dtNormal,_width,0,false);

            Part.SetMaterial("Стекло", 2.5);
            

            Part.Update();

            Document3D.SaveAs(SavePath);
        }


        public Glass(double h,double d2)
        {
            _diameter = d2;
            _width = h / 3; 
        }
    }
}
