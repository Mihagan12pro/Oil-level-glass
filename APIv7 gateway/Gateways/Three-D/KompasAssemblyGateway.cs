using APIv7_gateway.Interfaces;
using Kompas6Constants;
using KompasAPI7;
using NativeMethods;

namespace APIv7_gateway.Gateways.Three_D
{
    public class KompasAssemblyGateway : KompasGateway, ISerializableGateway
    {
        private IMateConstraints3D? _mateConstraints;
        public void Save(string file)
        {
            kompasDocument?.SaveAs(file);
        }


        public void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges)
        {
            if (kompasDocument == null)
                throw new NullReferenceException();

            kompasDocument.Close(howSave);
        }


        public KompasAssemblyGateway(bool isActive = false)
        {
            //IAssemblyDocument? assemblyDocument = ComConnector.GetInstance(kompasProgId) as IAssemblyDocument;

            //kompasDocument = assemblyDocument;

            //Part = (kompasDocument as IPartDocument)?.TopPart;
        }
    }
}
