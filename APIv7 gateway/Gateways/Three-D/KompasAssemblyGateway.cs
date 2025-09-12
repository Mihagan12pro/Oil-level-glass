using APIv7_gateway.Interfaces;
using Kompas6Constants;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
