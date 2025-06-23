using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Oil_level_glass.Kompas_classes
{
    internal class Housing: KompasDetail
    {
        private double _D, _d, _D2, _d1, _d2, _H, _h, _chamferAngle, _chamferLength;

        private int _n;

        private SketchShell _sketch1,_sketch2, _sketch3;
        private BossExtrusionShell _extrude1;
        private CutRotatedShell _cutRotated1, _cutRotated2;
        private ThreadShell _thread;
        private CircularCopyShell _circularCopy1;
        private ChamferShell _chamfer1;

        public Point3D ConstraintFacePoint { get; private set; }
        public Point3D ConstraintFacePoint2 { get; private set; }

        public Point3D ConstraintFacePoint3 { get; private set; }

        public Point3D ConstraintEdgePoint { get; private set; }

        public override void Build()
        {
            base.Build();

            _sketch1 = Sketch(planeXOZ,new List<Entity2D> { new Circle(new Point(0,0),_D, LineSegment.MainLine)});

            _extrude1 = BossExtrusion(new List<SketchShell> { _sketch1 }, true, Direction_Type.dtNormal, _H, 0, true);

            _sketch2 = Sketch(planeXOY, new List<Entity2D>
                {
                    new LineSegment
                        (
                            new Point2D() { X = 0, Y=0}, 
                            new Point2D() { X = 0, Y = _H},
                            Entity2D.AxesLine
                        ),

                    new LineSegment
                        (
                            new Point2D() { X = 0, Y = _H}, 
                            new Point2D() {X = _d1/2, Y = _H},
                            Entity2D.MainLine
                        ),

                    new LineSegment
                        (
                            new Point2D() {X = _d1/2, Y = _H}, 
                            new Point2D() {X = _d1/2, Y = _H - (_H - _h)/2},
                            Entity2D.MainLine
                        ),

                    new LineSegment
                        ( 
                            new Point2D() {X = _d1/2, Y = _H - (_H - _h)/2 }, 
                            new Point2D() {X = _d2/2, Y = _H - (_H - _h)/2}, 
                            Entity2D.MainLine
                       ),

                    new LineSegment
                       ( 
                            new Point2D() {X = _d2/2, Y = _H - (_H - _h)/2}, 
                            new Point2D() {X = _d2/2, Y = (_H - _h)/2 },
                            Entity2D.MainLine
                       ),

                    new LineSegment
                       ( 
                            new Point2D() {X = _d2/2, Y = (_H - _h)/2 }, 
                            new Point2D() { X = _d2/2, Y = (_H - _h)/2},
                            Entity2D.MainLine
                       ),

                    new LineSegment
                        ( 
                            new Point2D() { X = _d2/2, Y = (_H - _h)/2}, 
                            new Point2D() { X = _d1/2, Y = (_H - _h)/2},
                            Entity2D.MainLine
                        ),

                    new LineSegment
                        (
                            new Point2D() { X = _d1/2, Y = (_H - _h)/2}, 
                            new Point2D() {X = _d1/2, Y = 0}, 
                            Entity2D.MainLine
                        ),

                    new LineSegment
                        ( 
                            new Point2D() {X = _d1/2, Y = 0}, 
                            new Point2D() {X = 0, Y = 0}, 
                            Entity2D.MainLine
                        )
                }
            );


            _cutRotated1 = CutRotate(new List<SketchShell> { _sketch2});

            _sketch3 = Sketch(planeXOY, new List<Entity2D> 
                {
                    new LineSegment
                        (
                            new Point2D() { X = _D2/2, Y = 0},
                            new Point2D() { X = _D2/2, Y = _H},
                            Entity2D.AxesLine
                        ),
                    new LineSegment
                        (
                            new Point2D() { X = _D2/2, Y = _H},
                            new Point2D() { X = _D2/2 + _d/2, Y = _H},
                            Entity2D.MainLine
                        ),
                    new LineSegment
                        (
                            new Point2D() {  X = _D2/2 + _d/2, Y = _H },
                            new Point2D() { X = _D2/2 + _d/2, Y = 0 },
                            Entity2D.MainLine
                        ),
                    new LineSegment
                        (
                            new Point2D() { X = _D2/2 + _d/2, Y = 0},
                            new Point2D() { X =  _D2/2, Y = 0},
                            Entity2D.MainLine
                        )
                });

            _cutRotated2 = CutRotate(new List<SketchShell> { _sketch3});

            _thread = Thread(new List<I3DOperation> { _cutRotated2 });

            _circularCopy1 = CircularCopy(new List<ICopy> { _cutRotated2, _thread }, _n, planeXOY, planeYOZ, 360);

            _chamfer1 = Chamfer(new List<Point3D> { new Point3D() { X = _D/2, Y = 0, Z = 0} },_chamferLength,_chamferAngle);

            Part.Update();

            ConstraintFacePoint = new Point3D() {X = _d2 / 2, Y = _H - (_H - _h) / 2, Z = 0 };
            ConstraintEdgePoint = new Point3D() { X = _d2 / 2, Y = _H - (_H - _h) / 2, Z = 0 };

            ConstraintFacePoint2 = new Point3D() { X = _d2 / 2, Y = _H - (_H - _h) / 2, Z = 0 };

            ConstraintFacePoint3 = new Point3D() { X =( _d2 / 2 + _d1/2)/2, Y = _H - (_H - _h) / 2, Z = 0 };

            Document3D.SaveAs(SavePath);
        }


        public Housing(double D,double d, double D2,double d1,double d2, double H, double h, int n, double chamferAngle,double chamferLength)
        {
            _D = D;
            _D2 = D2;
            _d1 = d1;
            _d = d;
            _d2 = d2;
            _H = H;
            _h = h;
            _n = n;
            _chamferAngle = chamferAngle;
            _chamferLength = chamferLength;

            ModelColor = Color.Yellow;
        }
    }
}
