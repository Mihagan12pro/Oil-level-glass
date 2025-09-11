using Kompas6Constants;
using KompasAPI7;
using Oil_level_glass_Core.Data.Files;
using Oil_level_glass_Core.KompasApiV7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.KompasApiV7.Gateways.Three_D
{
    internal class KompasAssemblyGateway : Kompas3DGateway, ISerializableGateway
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


        public void Save(KompasFile file)
        {
            kompasDocument?.SaveAs(file.FullName);
        }


        public IPart7? OpenPart(KompasFile file)
        {
            return Part?.Parts.AddFromFile(file.FullName, true);
        }


        public KompasAssemblyGateway(IAssemblyDocument document3D)
        {
            kompasDocument = document3D;

            Part = document3D.TopPart;
        }
    }
}
