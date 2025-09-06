using Kompas6Constants;
using Oil_level_glass_Core.Data.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.KompasApiV7.Gateways
{
    internal interface ISerializableGateway
    {
        void Save(KompasFile file);
        //{
        //    KompasDocument?.SaveAs(file.FullName);
        //}


        void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges);
        //{
        //    KompasDocument?.Close(howSave);
        //}


        //public KompasSerializableGateway(bool isActiveDoc)
        //{
            
        //}
    }
}
