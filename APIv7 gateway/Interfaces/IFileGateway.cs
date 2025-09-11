using Kompas6Constants;

namespace APIv7_gateway.Interfaces
{
    internal interface IFileGateway
    {
        void Save(string filePath);


        void Close(DocumentCloseOptions howSave = DocumentCloseOptions.kdSaveChanges);
    }
}
