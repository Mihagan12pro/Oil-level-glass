using Kompas6Constants;
using Oil_level_glass_Core.Data.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.KompasApiV7.Interfaces
{
    internal interface ISerializableGateway
    {
        void Save(KompasFile file);


        void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges);
    }
}
