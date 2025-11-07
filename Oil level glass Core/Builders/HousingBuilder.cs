using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Delegates;
using Utils;

namespace Oil_level_glass_Core.Builders
{
    public class HousingBuilder : BaseDetailBuilder
    {
        public HousingModel Housing => (HousingModel)EntityModel;

        private ISketch _sketch1, _sketch2, _sketch3;

        private IExtrusion _extrusion1;
        private ICutExtrusion _cutExtrusion1;
        private IChamfer _chamfer1;

        private ICircle _mainCircle, _smallSocketCircle, _bigSocketCircle;
        private IPoint _point1;
        private IHole3D _hole1;
        private IThread _thread;
        private ICircularPattern _circularPattern1;
        private ILineSegment _helpLine;

        private IDiametralDimension _mainDiameterDimension, _smallSocketDiameterDimension, _bigSocketDiameterDimension;
        private ILineDimension _holeVertexLineDimension;

        private IFace _topFace;

        private IVariable7 _mainDiameterVariable, _smallSocketDiameterVariable, _bigSocketDiameterVariable;
        private IVariable7 _mainHeightVariable, _socketHeightVariable;
        private IVariable7 _chamferAngleVariable, _chamferLengthVariable;
        private IVariable7 _screwHolesCountVariable;

        public override void Create()
        {
            AddSketch1();
            ExtrudeSketch1();

            AddSketch2();
            ExtrudeSketch2();

            AddSketch3();
            CreateHole1();

            AddMirrorPattern1();

            AddChamfer();

            base.Create();
        }


        private void AddSketch1()
        {
            _sketch1 = sketchs.Add();
            _sketch1.Plane = Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY];
            _sketch1.Update();

            document2D = _sketch1.BeginEdit();
            InitDrawingContainer();

            _mainCircle = drawingContainer.Circles.Add();
            _mainCircle.Radius = Housing.MainDiameter * 0.5;
            _mainCircle.Xc = 0;
            _mainCircle.Yc = 0;
            _mainCircle.Update();


            _smallSocketCircle = drawingContainer.Circles.Add();
            _smallSocketCircle.Radius = Housing.SmallSocketDiameter * 0.5;
            _smallSocketCircle.Xc = 0;
            _smallSocketCircle.Yc = 0;
            _smallSocketCircle.Update();

            InitSymbolContaiber();

            _mainDiameterDimension = symbols2dContainer.DiametralDimensions.Add();
            _mainDiameterDimension.BaseObject = _mainCircle;
            _mainDiameterDimension.Angle = 45;
            _mainDiameterDimension.Update();

            _smallSocketDiameterDimension = symbols2dContainer.DiametralDimensions.Add();
            _smallSocketDiameterDimension.BaseObject = _smallSocketCircle;
            _smallSocketDiameterDimension.Angle = 135;
            _smallSocketDiameterDimension.Update();

            IFeature7 sketchFeature = (IFeature7)_sketch1;

            _mainDiameterVariable = Part.AddVariable("D", Housing.MainDiameter, "Диаметр корпуса");
            _smallSocketDiameterVariable = Part.AddVariable("D2", Housing.SmallSocketDiameter, "Диаметр центрального отверстия");

            AddVariableToDimension(_mainDiameterDimension, sketchFeature, _mainDiameterVariable.Name, "v1");
            AddVariableToDimension(_smallSocketDiameterDimension, sketchFeature, _smallSocketDiameterVariable.Name, "v2");

            MakePointFixed(_smallSocketCircle);
            MakeObjectsConcentric(_smallSocketCircle, _mainCircle);

            _sketch1.EndEdit();
        }


        private void ExtrudeSketch1()
        {
            _extrusion1 = extrusions.Add(ksObj3dTypeEnum.o3d_baseExtrusion);
            _extrusion1.Sketch = (Sketch)_sketch1;
            _extrusion1.Depth[true] = Housing.MainHeight;
            _extrusion1.Direction = ksDirectionTypeEnum.dtMiddlePlane;
            _extrusion1.Update();

            _mainHeightVariable = Part.AddVariable("H", Housing.MainHeight, "Высота корпуса");
            AddVariableToSolidBody((IFeature7)_extrusion1, _mainHeightVariable.Name, "Расстояние 1");
        }


        private void AddSketch2()
        {
            _sketch2 = sketchs.Add();
            _sketch2.Plane = Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY];
            _sketch2.Update();

            document2D = _sketch2.BeginEdit();

            InitDrawingContainer();

            _bigSocketCircle = drawingContainer.Circles.Add();
            _bigSocketCircle.Radius = Housing.BigSocketDiameter * 0.5;
            _bigSocketCircle.Xc = 0;
            _bigSocketCircle.Yc = 0;
            _bigSocketCircle.Update();

            InitSymbolContaiber();

            _bigSocketDiameterDimension = symbols2dContainer.DiametralDimensions.Add();
            _bigSocketDiameterDimension.BaseObject = _bigSocketCircle;
            _bigSocketDiameterDimension.Angle = 45;
            _bigSocketDiameterDimension.Update();

            _bigSocketDiameterVariable = Part.AddVariable("D1", Housing.BigSocketDiameter, "Внутренний диаметр корпуса");

            IFeature7 feature = (IFeature7)_sketch2;

            AddVariableToDimension(_bigSocketDiameterDimension, feature, _bigSocketDiameterVariable.Name, "v3");
            MakePointFixed(_bigSocketCircle);

            _sketch2.EndEdit();
        }


        private void ExtrudeSketch2()
        {
            _cutExtrusion1 = (ICutExtrusion)modelContainer.Extrusions.Add(ksObj3dTypeEnum.o3d_cutExtrusion);
            _cutExtrusion1.Sketch = (Sketch)_sketch2;
            _cutExtrusion1.Direction = ksDirectionTypeEnum.dtMiddlePlane;
            _cutExtrusion1.Depth[true] = Housing.SocketHeight;
            _cutExtrusion1.Update();

            _socketHeightVariable = Part.AddVariable("H1", Housing.SocketHeight, "Высота внутреннего отверстия корпуса");

            IFeature7 feature = (IFeature7)_cutExtrusion1;

            AddVariableToSolidBody(feature, _socketHeightVariable.Name, "Расстояние 2");
        }


        private void AddSketch3()
        {
            IFeature7 extrusion1Feature = (IFeature7)_extrusion1;

            object[] faces = ArrayMaster.ObjectToArray(extrusion1Feature.ModelObjects[ksObj3dTypeEnum.o3d_face]);

            CheckFace isPlanar = (IFace face) => 
                face.IsPlanar;

            GetFaceByPoint(faces, ref _topFace, isPlanar, Housing.MainDiameter * 0.5, 0, Housing.MainHeight * 0.5);

            _sketch3 = sketchs.Add();
            _sketch3.Plane = _topFace;

            _sketch3.Update();

            document2D = _sketch3.BeginEdit();

            InitDrawingContainer();

            _helpLine = drawingContainer.LineSegments.Add();
            _helpLine.Style = 3;
            _helpLine.X1 = 0;
            _helpLine.Y1 = 0;
            _helpLine.X2 = (Housing.MainDiameter * 0.5 + Housing.BigSocketDiameter * 0.5) / 2;
            _helpLine.Y2 = 0;
            _helpLine.Update();

            _point1 = drawingContainer.Points.Add();
            _point1.X = _helpLine.X2;
            _point1.Y = 0;
            _point1.Update();

            InitSymbolContaiber();

            _holeVertexLineDimension = symbols2dContainer.LineDimensions.Add();
            _holeVertexLineDimension.X1 = 0;
            _holeVertexLineDimension.Y1 = 0;
            _holeVertexLineDimension.X2 = _helpLine.X2;
            _holeVertexLineDimension.Y1 = 0;

            _holeVertexLineDimension.Y3 = _helpLine.X2;

            _holeVertexLineDimension.Update();

            MergePoints(_helpLine, 0, _holeVertexLineDimension, 0);
            MergePoints(_helpLine, 1, _holeVertexLineDimension, 1);
            MakePointFixed(_helpLine, 0);
            AlignPoint(_helpLine, 1, _helpLine, 0, true);
            MergePoints(_helpLine, 1, _point1, 0);

            IFeature7 sketchFeature = (IFeature7)_sketch3;

            AddVariableToDimension(_holeVertexLineDimension, sketchFeature, $"( {_mainDiameterVariable.Name}/2 + {_bigSocketDiameterVariable.Name}/2)/2", "v4");


            _sketch3.EndEdit();
        }


        private void CreateHole1()
        {
            _hole1 = modelContainer.Holes3D.Add();
            _hole1.ShowThread = true;

            IHoleDisposal holeDisposal = (IHoleDisposal)_hole1;
            IFeature7 sketch3Feature = (IFeature7)_sketch3;
            object[] vertices = ArrayMaster.ObjectToArray(sketch3Feature.ModelObjects[ksObj3dTypeEnum.o3d_vertex]);


            //foreach(var i in vertices)
            //{
            //    IVertex v = (IVertex)i;

            //    v.GetPoint(out double x, out double y, out double z);

            //    Console.WriteLine($"{x} {y} {z}");
            //}

            IVertex? vertex = null;

            double x = (Housing.MainDiameter * 0.5 + Housing.BigSocketDiameter * 0.5) / 2;
            double y = 0;
            double z = Housing.MainHeight * 0.5;

            GetVertexByPoint(vertices, ref vertex!, x, y, z);

            holeDisposal.AssociationVertex = vertex;
            holeDisposal.BaseSurface = _topFace;
            _hole1.DepthType = ksDepthTypeEnum.ksDTReachThrough;

            _thread = _hole1.Thread;
            _thread.AutoLenght = true;

            IThreadsParameters threadParameters = (IThreadsParameters)_thread;
            threadParameters.Init(Housing.Thread.Standard, Housing.Thread.NominalDiameter, Housing.Thread.Pitch);

            _thread.Update();

            _hole1.Update();
        }


        private void AddMirrorPattern1()
        {
            _circularPattern1 = (ICircularPattern)modelContainer.FeaturePatterns.Add(ksObj3dTypeEnum.o3d_circularCopy);

            _circularPattern1.Axis = Part.DefaultObject[ksObj3dTypeEnum.o3d_axisOZ];
            _circularPattern1.AddInitialObjects(_hole1);
            _circularPattern1.Count2 = Housing.ScrewHolesCount;

            _circularPattern1.Update();

            IFeature7 circularFeature = (IFeature7)_circularPattern1;


            _screwHolesCountVariable = Part.AddVariable("n", Housing.ScrewHolesCount, "Число отверстий");

            AddVariableToSolidBody(circularFeature, _screwHolesCountVariable.Name, "N 2");
        }


        private void AddChamfer()
        {
            _chamfer1 = modelContainer.Chamfers.Add();
            _chamfer1.Angle = Housing.ChamferAngle;
            _chamfer1.Distance1 = Housing.ChamferLength;

            IEdge? edge = null;

            GetEdgeByPoint(ArrayMaster.ObjectToArray(_topFace.LimitingEdges), ref edge!, Housing.MainDiameter * 0.5, 0, Housing.MainHeight * 0.5);

            _chamfer1.BaseObjects = new object[] { edge };

            _chamfer1.Update();

            IFeature7 chamferFeature = (IFeature7)_chamfer1;

            _chamferAngleVariable = Part.AddVariable("alpha", Housing.ChamferAngle, "Угол фаски");
            _chamferLengthVariable = Part.AddVariable("l1", Housing.ChamferLength, "Длина фаски");

            AddVariableToSolidBody(chamferFeature, _chamferAngleVariable.Name, "Угол");
            AddVariableToSolidBody(chamferFeature, _chamferLengthVariable.Name, "Длина 1");
        }


        public HousingBuilder(bool createNewDocument): base(createNewDocument)
        {
            
        }
    }
}
