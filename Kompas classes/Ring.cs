using Kompas6API5;
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
        public double Width { get; private set; }
        private double _diameter1;
        private double _diameter2;

        private SketchShell _sketch1;
        private BossExtrusionShell _extrusion1;

        public Point3D ConstraintFacePoint { get; private set; }

        public Point3D ConstraintEdgePoint2 { get; private set; }


        public int ConstraintEdgeIndex { get; private set; }

        


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

            _extrusion1 = BossExtrusion(new List<SketchShell> { _sketch1 }, true, Direction_Type.dtNormal, Width, 0, false);

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

                    if (x1 == _diameter2 / 2 && y1 == Width)
                    {
                        ConstraintEdgeIndex = i;
                    }
                }
            }

            ksEntityCollection faces = Part.EntityCollection((short)Obj3dType.o3d_face);



            faces.SelectByPoint(_diameter1 / 2, Width, 0);


           

          
            ConstraintFacePoint = new Point3D() { X = _diameter1 / 2, Y = Width, Z = 0 };

            ConstraintEdgePoint2 = new Point3D() { X = (_diameter1 / 2 + _diameter2/2)/2, Y = 0, Z = 0 };
            

            Part.SetMaterial("Резина", 1.6);
            Part.SetAdvancedColor(Color.Black.ToArgb());

            Part.Update();

            Document3D.SaveAs(SavePath);
        }


        public Ring(double h, double d2,double d1)
        {
            _diameter1 = d2;
            _diameter2 = d1;
            Width = h/3;
        }
    }
}
