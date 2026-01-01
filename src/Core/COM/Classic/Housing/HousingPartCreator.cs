using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.COM.Extensions.Collections;
using Oil_level_glass.COM.Extensions.Containers;
using Oil_level_glass.COM.Extensions.ModelObjects;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core.Classic.Housing;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Shared;
using Shared.Points;

namespace Oil_level_glass.COM.Classic.Housing
{
    internal class HousingPartCreator
        : ComSolidPartCreator<HousingModel>, IHousingPartCreator
    {
        private Sketch? _sketch1;
        private Sketch? _sketch2;
        private Sketch? _sketch3;

        private IHole3D? _screwHole;

        private IExtrusion? _extrusion1;
        private ICutExtrusion? _extrusion2;

        private ICircularPattern? _circularPattern;

        private IVariable7? _externalDiameterVariable;
        private IVariable7? _internalDiameterVariable;
        private IVariable7? _socketDiameterVariable;

        private IVariable7? _screwHolesDistanceVariable;

        private IVariable7? _heightVariable;

        private IVariable7? _countOfScrewHolesVariable;

        public void AddSketch1()
        {
            _sketch1 = ModelContainer.Sketchs.Add();
            _sketch1.Plane = Part7?.GetPlaneXOY();
            _sketch1.Update();

            IDrawingContainer sketch1DrawingContainer = _sketch1.GetDrawingContainer();

            ICircle externalCircle = sketch1DrawingContainer.AddCircle(new Point2DCrossApi(0, 0), 90 / 2);
            ICircle internalCircle = sketch1DrawingContainer.AddCircle(new Point2DCrossApi(0, 0), 50 / 2);

            ISymbols2DContainer symbols2DContainer = sketch1DrawingContainer.GetSymbols2DContainer();

            IDiametralDimension externalDiametralDimension = symbols2DContainer.AddDiametralDimension(externalCircle);
            IDiametralDimension internalDiametralDimension = symbols2DContainer.AddDiametralDimension(internalCircle);

            _sketch1.AddVariableToDimension(externalDiametralDimension, "v1", _externalDiameterVariable!.Name);
            _sketch1.AddVariableToDimension(internalDiametralDimension, "v2", _internalDiameterVariable!.Name);

            _sketch1.EndEdit();
        }

        public void EditSketch1()
        {
            throw new NotImplementedException();
        }

        public void ExtrudeSketch1()
        {
            _extrusion1 = ModelContainer.Extrusions.Add(Kompas6Constants3D.ksObj3dTypeEnum.o3d_bossExtrusion);

            _extrusion1.Sketch = _sketch1;
            _extrusion1.Depth[true] = 8;
            _extrusion1.Direction = Kompas6Constants3D.ksDirectionTypeEnum.dtMiddlePlane;
            _extrusion1.ExtrusionType[true] = Kompas6Constants3D.ksEndTypeEnum.etBlind;

            _extrusion1.Update();

            _extrusion1.AddVariableToObject(_heightVariable!.Name, "Расстояние 1");
        }

        public void EditSketch1Extrusion()
        {
            throw new NotImplementedException();
        }


        public void AddSketch2()
        {
            _sketch2 = ModelContainer.Sketchs.Add();
            _sketch2.Plane = Part7?.GetPlaneXOY();
            _sketch2.Update();

            IDrawingContainer sketch2DrawingContainer = _sketch2.GetDrawingContainer();

            ICircle circle = sketch2DrawingContainer.AddCircle(new Point2DCrossApi(0, 0), 60 / 2);

            ISymbols2DContainer symbols2DContainer = sketch2DrawingContainer.GetSymbols2DContainer();

            IDiametralDimension diameterDimension = symbols2DContainer.AddDiametralDimension(circle);
            _sketch2.AddVariableToDimension(diameterDimension, "v3", _socketDiameterVariable!.Name);

            _sketch2.EndEdit();
        }

        public void EditSketch2()
        {
            throw new NotImplementedException();
        }

        public void ExtrudeSketch2()
        {
            _extrusion2 = (ICutExtrusion)ModelContainer.Extrusions.Add(Kompas6Constants3D.ksObj3dTypeEnum.o3d_cutExtrusion);
            
            _extrusion2.Sketch = _sketch2;
            _extrusion2.Direction = Kompas6Constants3D.ksDirectionTypeEnum.dtMiddlePlane;
            _extrusion2.Depth[true] = 6;
            _extrusion2.Update();
        }

        public void EditSketch2Extrusion()
        {
            throw new NotImplementedException();
        }


        public void AddSketch3()
        {
            IFace face = Part7!.GetFaces()
                .Where(f => f.IsPlanar)
                    .ToArray()
                        .GetFaceByAxis(AxisCrossApi.OZ, 4);

            _sketch3 = ModelContainer.Sketchs.Add();
            _sketch3.Plane = face;
            _sketch3.Update();

            IDrawingContainer sketch3DrawingContainer = _sketch3.GetDrawingContainer();

            IPoint point = sketch3DrawingContainer.Points.Add();
            point.X = 36;
            point.Y = 0;
            point.Update();

            ILineSegment lineSegment = sketch3DrawingContainer.AddLineSegment(new Point2DCrossApi(0, 0), new Point2DCrossApi(36, 0), 3);
            lineSegment.MakePointFixed(LinePoint.Start);
            lineSegment.MakePointMerged(point, LinePoint.End);

            ISymbols2DContainer symbols2DContainer = sketch3DrawingContainer.GetSymbols2DContainer();

            ILineDimension lineDimension = symbols2DContainer.AddLineDimension(lineSegment);
            _sketch3.AddVariableToDimension(lineDimension, "v4", $"{_screwHolesDistanceVariable!.Name}/2");

            _sketch3.EndEdit();
        }

        public void EditRounding()
        {
            throw new NotImplementedException();
        }

        public void EditScrewHoles()
        {
            throw new NotImplementedException();
        }

        public void EditSketch3()
        {
            throw new NotImplementedException();
        }

        public void AddRounding()
        {
            throw new NotImplementedException();
        }

        public void AddScrewHoles()
        {
            IFace face = Part7!.GetFaces()
                .Where(f => f.IsPlanar)
                    .ToArray()
                        .GetFaceByAxis(AxisCrossApi.OZ, 4);

            _screwHole = ModelContainer.Holes3D.Add();
            _screwHole.HoleType = ksHoleTypeEnum.ksHTBase;
            _screwHole.ShowThread = true;

            IVertex[] vertices = _sketch3!.GetVertices();

            IHoleDisposal holeDisposal = (IHoleDisposal)_screwHole;

            holeDisposal!.AssociationVertex = _sketch3!.GetVertices()
                .Where(v => v.ToPoint() == new Point3DCrossApi(36, 0, 4))
                    .First();
            holeDisposal.BaseSurface = face;


            IThread thread = _screwHole.Thread;
            thread.AutoLenght = true;

            IThreadsParameters threadsParameters = (IThreadsParameters)thread;
            threadsParameters.Init("Метрическая резьба с крупным шагом ГОСТ 24705-2004", 8, 1.25);
            thread.Update();

            _screwHole.Update();

            _circularPattern = (ICircularPattern)ModelContainer.FeaturePatterns.Add(ksObj3dTypeEnum.o3d_circularCopy);
            _circularPattern.Axis = Part7!.GetOZ();
            _circularPattern.Step2 = 360;
            _circularPattern.Count2 = 4;
            _circularPattern.AddInitialObjects(_screwHole);

            _circularPattern.Update();

            _circularPattern.AddVariableToObject(_countOfScrewHolesVariable!.Name, "N 2");
        }

        public override void Initialize()
        {
            base.Initialize();

            _externalDiameterVariable = Part7!.AddVariable("D", 90, "Внешний диаметр корпуса");
            _internalDiameterVariable = Part7!.AddVariable("D1", 50, "Внутренний диаметр корпуса");
            _socketDiameterVariable = Part7!.AddVariable("D3", 60, "Диаметр отсека под линзу");

            _screwHolesDistanceVariable = Part7!.AddVariable("Ds", 72, "Расстояние между отверстиями под винты");

            _heightVariable = Part7!.AddVariable("H", 8, "Высота корпуса");

            _countOfScrewHolesVariable = Part7!.AddVariable("n", 4, "Количество отверстий под винты");
        }
    }
}
