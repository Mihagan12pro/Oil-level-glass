using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Core.COM.Api7.Extensions;
using Oil_level_glass.Core.COM.COMProviders;
using Oil_level_glass.Core.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Shared.Results;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Oil_level_glass.Core.COM.Api7.Glass
{
    internal class GlassPartCreator7 : IGlassPartCreator
    {
        private IApplication _application;


        private IPart7 _glassPart;
        private IPartDocument _document;

        public GlassModel Model { get; set; }


        public Result Create()
        {
            Result result = null;

            try
            {
                _application = (IApplication)ComConnector.GetInstance(ProgIds.Api7);
            }
            catch(COMException)
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

                _document =
                    (IPartDocument)_application.Documents.Add(
                        DocumentTypeEnum.ksDocumentPart);

                _glassPart = _document.TopPart;

                IModelContainer modelContainer =
                    (IModelContainer)_glassPart;

                IPlane3D planeXOY =
                    _glassPart.DefaultObject[
                        ksObj3dTypeEnum.o3d_planeXOY] as IPlane3D;

                Sketch sketch = modelContainer.Sketchs.Add();
                sketch.Plane = planeXOY;

                IKompasDocument2D document2D =
                    sketch.BeginEdit();

                ICircle circle = document2D.AddCircle();

                circle.Xc = 0;
                circle.Yc = 0;
                circle.Radius = Model.Diameter * 0.5;

                circle.Update();

                sketch.EndEdit();

                IExtrusion extrusion =
                    modelContainer.Extrusions.Add(
                        ksObj3dTypeEnum.o3d_baseExtrusion);

                extrusion.ExtrusionType[true] =
                    ksEndTypeEnum.etBlind;

                extrusion.Direction =
                    ksDirectionTypeEnum.dtMiddlePlane;

                extrusion.Depth[true] =
                    Model.Height;

                extrusion.Sketch = sketch;

                extrusion.Update();

                _glassPart.SetMaterial(Model.Material);
                _glassPart.SetNaming(Model.File.Name);
                _glassPart.SetAdavancedColor(Model.Appearance);

                _application.SearchForErrors(out result);

                _document.SaveAs(Model.File.FullName);
            }

            return result;
        }
    }
}
