using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Core.COM.Api7.Extensions;
using Oil_level_glass.Core.COM.COMProviders;
using Oil_level_glass.Core.OilLevelGlass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Shared.Results;
using System.Runtime.InteropServices;

namespace Oil_level_glass.Core.COM.Api7.OilLevelGlass
{
    internal class OilLevelGlassPartCreator : IOilLevelGlassPartCreator
    {
        private HousingModel _housing;
        private GlassModel _glass;
        private RubberStripModel _rubberStrip;

        private IApplication _application;
        private IAssemblyDocument _document;
        private IPart7 _oilLevelGlassPart;

        public OilLevelGlassModel Model { get; set; }

        public Result Create()
        {
            _housing = Model.HousingModel;
            _rubberStrip = Model.RubberStripModel;
            _glass = Model.GlassModel;

            Result result = null;

            try
            {
                _application = (IApplication)ComConnector.GetInstance(ProgIds.Api7);
            }
            catch (COMException ex)
            {
                
            }
            finally
            {
                if (_application == null)
                {
                    Type? t = Type.GetTypeFromProgID("KOMPAS.Application.5");

                    var kompas = (KompasObject)Activator.CreateInstance(t);
                    kompas.Visible = true;
                    kompas.ActivateControllerAPI();

                    _application = kompas.ksGetApplication7();
                }

                _document = (IAssemblyDocument)_application.Documents.Add(DocumentTypeEnum.ksDocumentAssembly);

                _oilLevelGlassPart = _document.TopPart;

                IModelContainer modelContainer = (IModelContainer)_oilLevelGlassPart;

                Part7 housingPart = _oilLevelGlassPart.Parts.AddFromFile(_housing.File.FullName);
                housingPart.Fixed = true;

                Part7 rubberStrip1Part = _oilLevelGlassPart.Parts.AddFromFile(_rubberStrip.File.FullName);
                Part7 rubberStrip2Part = _oilLevelGlassPart.Parts.AddFromFile(_rubberStrip.File.FullName);
                Part7 glassPart = _oilLevelGlassPart.Parts.AddFromFile(_glass.File.FullName);

                IFace housingMainCylinderFace = housingPart.GetFaceByPoint(_housing.MainDiameter * 0.5, 0, 0, (IFace face) => face.IsCylinder);
                IFace housingGlassSocketBottomFace = housingPart.GetFaceByPoint(_housing.GlassSocketDiameter * 0.5, 0, -_housing.GlassSocketHeight * 0.5, (IFace face) => face.IsPlanar);

                IFace rubberStrip1TopFace = rubberStrip1Part.GetFaceByPoint(_rubberStrip.InternalDiameter * 0.5, 0, _rubberStrip.Height * 0.5, (IFace face) => face.IsPlanar);
                IFace rubberStrip1BottomFace = rubberStrip1Part.GetFaceByPoint(_rubberStrip.InternalDiameter * 0.5, 0, -_rubberStrip.Height * 0.5, (IFace face) => face.IsPlanar);
                IFace rubberStrip1CylindricFace = rubberStrip1Part.GetFaceByPoint(_rubberStrip.ExternalDiameter * 0.5, 0, -_rubberStrip.Height * 0.5, (IFace face) => face.IsCylinder);

                IFace rubberStrip2TopFace = rubberStrip2Part.GetFaceByPoint(_rubberStrip.InternalDiameter * 0.5, 0, _rubberStrip.Height * 0.5, (IFace face) => face.IsPlanar);
                IFace rubberStrip2BottomFace = rubberStrip2Part.GetFaceByPoint(_rubberStrip.InternalDiameter * 0.5, 0, -_rubberStrip.Height * 0.5, (IFace face) => face.IsPlanar);
                IFace rubberStrip2CylindricFace = rubberStrip2Part.GetFaceByPoint(_rubberStrip.ExternalDiameter * 0.5, 0, -_rubberStrip.Height * 0.5, (IFace face) => face.IsCylinder);

                IFace glassCylindricFace = glassPart.GetFaceByPoint(_glass.Diameter * 0.5, 0, 0, (IFace face) => face.IsCylinder);
                IFace glassBottomFace = glassPart.GetFaceByPoint(0, 0, -_glass.Height * 0.5, (IFace face) => !face.IsCylinder);
                IFace glassTopFace = glassPart.GetFaceByPoint(0, 0, _glass.Height * 0.5, (IFace face) => face.IsPlanar);

                IMateConstraint3D strip1HousingConcentric = _oilLevelGlassPart.MateConstraints.Add(MateConstraintType.mc_Concentric);
                strip1HousingConcentric.BaseObject1 = housingMainCylinderFace;
                strip1HousingConcentric.BaseObject2 = rubberStrip1CylindricFace;
                strip1HousingConcentric.Update();

                IMateConstraint3D strip1HousingCoincidence = _oilLevelGlassPart.MateConstraints.Add(MateConstraintType.mc_Coincidence);
                strip1HousingCoincidence.BaseObject1 = housingGlassSocketBottomFace;
                strip1HousingCoincidence.BaseObject2 = rubberStrip1BottomFace;
                strip1HousingCoincidence.Update();

                IMateConstraint3D stripsConcentric = _oilLevelGlassPart.MateConstraints.Add(MateConstraintType.mc_Concentric);
                stripsConcentric.BaseObject1 = rubberStrip1CylindricFace;
                stripsConcentric.BaseObject2 = rubberStrip2CylindricFace;
                stripsConcentric.Update();

                IMateConstraint3D glassStripsConcentric = _oilLevelGlassPart.MateConstraints.Add(MateConstraintType.mc_Concentric);
                glassStripsConcentric.BaseObject1 = rubberStrip1CylindricFace;
                glassStripsConcentric.BaseObject2 = glassCylindricFace;
                glassStripsConcentric.Update();

                IMateConstraint3D glassStrip2Coincidence = _oilLevelGlassPart.MateConstraints.Add(MateConstraintType.mc_Coincidence);
                glassStrip2Coincidence.BaseObject1 = glassTopFace;
                glassStrip2Coincidence.BaseObject2 = rubberStrip2BottomFace;
                glassStrip2Coincidence.Update();

                IMateConstraint3D glassStrip1Coincidence = _oilLevelGlassPart.MateConstraints.Add(MateConstraintType.mc_Coincidence);
                glassStrip1Coincidence.BaseObject1 = glassBottomFace;
                glassStrip1Coincidence.BaseObject2 = rubberStrip1TopFace;
                glassStrip1Coincidence.Update();

                _application.SearchForErrors(out result);
            }

            return result;
        }
    }
}
