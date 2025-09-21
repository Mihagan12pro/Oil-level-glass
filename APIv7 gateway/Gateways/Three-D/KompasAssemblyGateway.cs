using APIv7_gateway.Interfaces;
using Kompas6Constants;
using KompasAPI7;
using NativeMethods;

namespace APIv7_gateway.Gateways.Three_D
{
    public class KompasAssemblyGateway : Kompas3DGateway, ISerializableGateway
    {
        private IMateConstraints3D? _mateConstraints;
        public override IPart7? Part
        {
            get => base.Part;
            protected set
            {
                base.Part = value;

                _mateConstraints = value?.MateConstraints;
            }
        }


        public void Save(string file)
        {
            kompasDocument?.SaveAs(file);
        }


        public IPart7? OpenPart(string file)
        {
            return Part?.Parts.AddFromFile(file, true);
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
