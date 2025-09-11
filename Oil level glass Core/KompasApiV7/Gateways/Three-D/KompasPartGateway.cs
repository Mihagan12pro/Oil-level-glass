using Kompas6Constants;
using KompasAPI7;
using Oil_level_glass_Core.Data.Files;
using Oil_level_glass_Core.KompasApiV7.Interfaces;

namespace Oil_level_glass_Core.KompasApiV7.Gateways.Three_D
{
    internal class KompasPartGateway : Kompas3DGateway, ISerializableGateway
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


        public void Save(KompasFile file)
        {
            kompasDocument?.SaveAs(file.FullName);
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
