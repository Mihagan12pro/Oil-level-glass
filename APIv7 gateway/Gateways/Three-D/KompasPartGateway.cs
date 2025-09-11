using Kompas6Constants;
using KompasAPI7;
using APIv7_gateway.Interfaces;

namespace APIv7_gateway.Gateways.Three_D
{
    internal class KompasPartGateway : Kompas3DGateway, IFileGateway
    {
        private IModelContainer? _modelContainer;
        public IModelContainer? ModelContainer => _modelContainer;


        public override IPart7? Part
        {
            get => base.Part;
            protected set
            {
                base.Part = value;

                _modelContainer = base.Part as IModelContainer;
            }
        }



        public void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges)
        {
            kompasDocument?.Close(howSave);
        }


        public void Save(string file)
        {
            kompasDocument?.SaveAs(file);
        }


        public KompasPartGateway(IPartDocument document3D)
        {
            kompasDocument = document3D;

            Part = document3D.TopPart;
        }


        public KompasPartGateway(IPart7 externalPart)
        {
            Part = externalPart;
        }
    }
}
