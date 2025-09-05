using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;

namespace Oil_level_glass_Core.Services
{
    internal static class DocumentManager
    {
        private static IKompasDocument3D CreateDocument3D(bool isActive)
        {
            KompasObject kompasObject = (KompasObject)COMConnector.GetInstance("KOMPAS.Application.5");

            if (isActive)
            {
                IApplication application = (IApplication)kompasObject.ksGetApplication7();

                return (IKompasDocument3D)application.ActiveDocument;
            }

            ksDocument3D documentV5 = (ksDocument3D)kompasObject.Document3D();

            documentV5.Create();

            IKompasDocument document = (IKompasDocument)kompasObject.TransferInterface(documentV5, (int)ksAPITypeEnum.ksAPI7Dual, (int)Obj3dType.o3d_document);

            return (IKompasDocument3D)document;
        }


        public static IPartDocument GetPartDocument(bool isActive = false)
        {
            return (IPartDocument)CreateDocument3D(isActive);
        }


        public static IAssemblyDocument GetAssemblyDocument(bool isActive = false)
        {
            return (IAssemblyDocument)CreateDocument3D(isActive);
        }
    }
}
