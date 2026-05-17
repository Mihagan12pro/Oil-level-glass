using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Core.COM.Api7.Extensions;
using Oil_level_glass.Core.COM.COMProviders;
using Oil_level_glass.Core.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Materials;
using Shared.Results;
using System.Runtime.InteropServices;

namespace Oil_level_glass.Core.COM.Api7.RubberStrip
{
    internal class RubberStripCreator7 : IRubberStripPartCreator
    {
        private readonly RubberStripModel _rubberStrip;

        private IApplication _application;


        private IPart7 _rubberStripPart;
        private IPartDocument _document;

        public Result Create()
        {
            Result result = null;

            try
            {
                _application = (IApplication)ComConnector.GetInstance(ProgIds.Api7);

                _document = (IPartDocument)_application.Documents.Add(DocumentTypeEnum.ksDocumentPart);

                _rubberStripPart = (IPart7)_document.TopPart;
                IModelContainer modelContainer = (IModelContainer)_rubberStripPart;

                IPlane3D planeXOY = _rubberStripPart.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY] as IPlane3D;

                Sketch sketch = modelContainer.Sketchs.Add();
                sketch.Plane = planeXOY;

                IKompasDocument2D document2D = sketch.BeginEdit();

                ICircle externalCircle = document2D.AddCircle();
                externalCircle.Xc = 0;
                externalCircle.Yc = 0;
                externalCircle.Radius = _rubberStrip.ExternalDiameter * 0.5;
                externalCircle.Update();

                ICircle internalCircle = document2D.AddCircle();
                internalCircle.Xc = 0;
                internalCircle.Yc = 0;
                internalCircle.Radius = _rubberStrip.InternalDiameter * 0.5;
                internalCircle.Update();

                sketch.EndEdit();

                IExtrusion extrusion = modelContainer.Extrusions.Add(ksObj3dTypeEnum.o3d_baseExtrusion);
                extrusion.ExtrusionType[true] = ksEndTypeEnum.etBlind;
                extrusion.Direction = ksDirectionTypeEnum.dtMiddlePlane;
                extrusion.Depth[true] = _rubberStrip.Height;
                extrusion.Sketch = sketch;
                extrusion.Update();

                _rubberStripPart.SetMaterial(_rubberStrip.Material);
                _rubberStripPart.SetNaming(_rubberStrip.File.Name);
                _rubberStripPart.SetAdavancedColor(_rubberStrip.Appearance);

                _application.SearchForErrors(out result);

                _document.SaveAs(_rubberStrip.File.FullName);
            }
            catch (COMException ex)
            {
                result = new Result(false, ex.Message);
            }

            return result;
        }

        public RubberStripCreator7(RubberStripModel rubberStrip)
        {
            _rubberStrip = rubberStrip;
        }
    }
}
