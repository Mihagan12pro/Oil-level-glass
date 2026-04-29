using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Core.COM.Api7.Extensions;
using Oil_level_glass.Core.COM.COMProviders;
using Oil_level_glass.Core.Housing;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Operations.Chamfers;
using Oil_level_glass.Model.Data.ScrewHoles;
using Shared.Results;
using System.Runtime.InteropServices;

namespace Oil_level_glass.Core.COM.Api7.Housing
{
    internal class HousingPartCreator7 : IHousingPartCreator
    {
        private readonly HousingModel _housing;

        private IApplication _application;


        private IPart7 _housingPart;
        private IPartDocument _document;


        public Result Create()
        {
            Result result = null;

            try
            {
                _application = (IApplication)ComConnector.GetInstance(ProgIds.Api7);

                _document = (IPartDocument)_application.Documents.Add(DocumentTypeEnum.ksDocumentPart);

                _housingPart = (IPart7)_document.TopPart;

                IModelContainer modelContainer = (IModelContainer)_housingPart;

                IPlane3D planeXOY = _housingPart.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY] as IPlane3D;

                Sketch sketch1 = modelContainer.Sketchs.Add();
                sketch1.Plane = planeXOY;

                IKompasDocument2D document2D = sketch1.BeginEdit();

                ICircle centralHoleCircle = document2D.AddCircle();
                centralHoleCircle.Radius = _housing.CentralHoleDiameter * 0.5;
                centralHoleCircle.Xc = 0;
                centralHoleCircle.Yc = 0;
                centralHoleCircle.Update();

                ICircle mainCircle = document2D.AddCircle();
                mainCircle.Radius = _housing.MainDiameter * 0.5;
                mainCircle.Xc = 0;
                mainCircle.Yc = 0;
                mainCircle.Update();

                sketch1.EndEdit();


                IExtrusion sketch1Extrusion = modelContainer.Extrusions.Add(ksObj3dTypeEnum.o3d_baseExtrusion);
                sketch1Extrusion.Sketch = sketch1;
                sketch1Extrusion.Depth[true] = _housing.MainHeight;
                sketch1Extrusion.Direction = ksDirectionTypeEnum.dtMiddlePlane;
                sketch1Extrusion.ExtrusionType[true] = ksEndTypeEnum.etBlind;
                sketch1Extrusion.Update();


                ISketch sketch2 = modelContainer.Sketchs.Add();
                sketch2.Plane = planeXOY;

                document2D = sketch2.BeginEdit();

                ICircle glassSocketDiameter = document2D.AddCircle();
                glassSocketDiameter.Radius = _housing.GlassSocketDiameter * 0.5;
                glassSocketDiameter.Xc = 0;
                glassSocketDiameter.Yc = 0;
                glassSocketDiameter.Update();

                sketch2.EndEdit();

                ICutExtrusion cutSketch2 = (ICutExtrusion)modelContainer.Extrusions.Add(ksObj3dTypeEnum.o3d_cutExtrusion);
                cutSketch2.Sketch = (Sketch)sketch2;
                cutSketch2.Depth[false] = _housing.GlassSocketHeight;
                cutSketch2.Direction = ksDirectionTypeEnum.dtMiddlePlane;
                cutSketch2.ExtrusionType[true] = ksEndTypeEnum.etBlind;

                cutSketch2.Update();

                var facesObj = modelContainer.Objects[ksObj3dTypeEnum.o3d_face];

                IFace face = _housingPart.GetFaceByPoint(_housing.MainDiameter * 0.5, 0, _housing.MainHeight * 0.5, (IFace f) => f.IsPlanar);
                IEdge edge = _housingPart.GetEdgeByPoint(_housing.MainDiameter * 0.5, 0, _housing.MainHeight * 0.5);

                ISketch sketch3 = modelContainer.Sketchs.Add();
                sketch3.Plane = face;

                sketch3.Update();

                document2D = sketch3.BeginEdit();

                IPoint point = document2D.AddPoint();
                point.X = _housing.ScrewHolesDistance * 0.5;
                point.Y = 0;
                point.Update();

                sketch3.EndEdit();

                IVertex vertex = ((IFeature7)sketch3).GetVertexByPoint(_housing.ScrewHolesDistance * 0.5, 0, _housing.MainHeight * 0.5);

                IHole3D hole = modelContainer.Holes3D.Add();
                hole.Diameter = ((BasicScrewHoleModel)_housing.Hole).Diameter;
                hole.ShowThread = true;

                IThread thread = hole.Thread;
                thread.AutoDiameter = true;
                thread.AutoLenght = true;

                IHoleDisposal holeDisposal = (IHoleDisposal)hole;
                holeDisposal.BaseSurface = face;
                holeDisposal.AssociationVertex = vertex;

                hole.Update();  


                ICircularPattern circularPattern = (ICircularPattern)modelContainer.FeaturePatterns.Add(ksObj3dTypeEnum.o3d_circularCopy);
                circularPattern.Step2 = 360;
                circularPattern.Count2 = _housing.ScrewHolesCount;
                circularPattern.AddInitialObjects(hole);
                circularPattern.Axis = _housingPart.DefaultObject[ksObj3dTypeEnum.o3d_axisOZ];

                circularPattern.Update();

                IChamfer chamfer = modelContainer.Chamfers.Add();
                chamfer.Angle = ((ChamferAngleLengthModel)_housing.Chamfer).Angle;
                chamfer.Distance1 = _housing.Chamfer.Side1;
                chamfer.BuildingType = ksChamferBuildingTypeEnum.ksChamferSideAngle;
                chamfer.BaseObjects = edge;

                chamfer.Update();

                _housingPart.SetAdavancedColor(_housing.Appearance);
                _housingPart.SetMaterial(_housing.Material);
                _housingPart.SetNaming(_housing.File.Name);

                _application.SearchForErrors(out result);

                _document.SaveAs(_housing.File.FullName);
            }
            catch (COMException ex)
            {
                result = new Result(false, ex.Message);
            }

            return result;
        }

        public HousingPartCreator7(HousingModel housing)
        {
            _housing = housing;
        }
    }
}
