using Kompas6Constants;
using KompasAPI7;
using APIv7_gateway.Interfaces;

namespace APIv7_gateway.Gateways.Three_D
{
    internal class KompasAssemblyGateway : Kompas3DGateway, IFileGateway
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


        public void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges)
        {
            kompasDocument?.Close(howSave);
        }


        public void Save(string file)
        {
            kompasDocument?.SaveAs(file);
        }


        public IPart7? OpenPart(string file)
        {
            return Part?.Parts.AddFromFile(file, true);
        }


        public KompasAssemblyGateway(IAssemblyDocument document3D)
        {
            kompasDocument = document3D;

            Part = document3D.TopPart;
        }
    }
}
