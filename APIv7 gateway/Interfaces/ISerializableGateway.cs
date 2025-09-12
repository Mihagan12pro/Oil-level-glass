using Kompas6Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Interfaces
{
    public interface ISerializableGateway
    {
        void Save(string filePath);


        void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges);
    }
}
