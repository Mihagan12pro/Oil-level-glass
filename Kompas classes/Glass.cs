using Kompas6API5;
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
        public double Width { get; private set; }
        private double _diameter;

        private SketchShell _sketch1;
        private BossExtrusionShell _extrusion1;

        public int ConstraintEdgeIndex { get; private set; }

        public Point3D ConstraintTopFacePoint { get; private set; }
        public Point3D ConstraintBottomFacePoint { get; private set; }

        public Point3D ConstraintBottomEdgePoint { get; private set; }

        public override void Build()
        {
            base.Build();

            Part.SetAdvancedColor(Color.Gray.ToArgb(),-47,-47,-47,-47,-60,-47);

            _sketch1 = Sketch(planeXOZ,new List<Entity2D> { new Circle(new Point(0,0),_diameter,Entity2D.MainLine)});
            _extrusion1 = BossExtrusion(new List<SketchShell> { _sketch1},true,Direction_Type.dtNormal,Width,0,false);

            Part.SetMaterial("Стекло", 2.5);

            ksEntityCollection edges = Part.EntityCollection((short)Obj3dType.o3d_edge);

            for (int i = 0; i < edges.GetCount(); i++)
            {
                ksEntity edge = edges.GetByIndex(i);
                ksEdgeDefinition edgeDef = edge.GetDefinition();

                ksVertexDefinition vertex = edgeDef.GetVertex(true);

                double x1, y1, z1;

                if (vertex != null)
                {
                    vertex.GetPoint(out x1, out y1, out z1);

                    if (x1 == _diameter / 2 && y1 == Width)
                    {
                        ConstraintEdgeIndex = i;
                    }
                }
            }
            ConstraintTopFacePoint = new Point3D() {X = _diameter / 2, Y  = Width, Z = 0};

            ConstraintBottomFacePoint = new Point3D() {X =  _diameter / 3,Y = 0,Z = 0 };

            ConstraintBottomEdgePoint = new Point3D() { X = _diameter / 3, Y = 0, Z = 0 };

            Part.Update();

            Document3D.SaveAs(SavePath);
        }


        public Glass(double h,double d2)
        {
            _diameter = d2;
            Width = h / 3; 
        }
    }
}
