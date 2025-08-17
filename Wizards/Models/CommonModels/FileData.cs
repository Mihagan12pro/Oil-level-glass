using Oil_level_glass.BaseClasses.ModelsBase;
using System.ComponentModel.DataAnnotations;
using Oil_level_glass.Utilities.Attributes;
using Oil_level_glass.Properties;
using Oil_level_glass.Services;

namespace Oil_level_glass.Wizards.Models.CommonModels
{
    internal class FileData : BaseModel
    {
        public readonly string Extension;


        private string? directory;
        [Directory(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Resources.DirectoryNotExistStrError))]
        public string? Directory
        {
            get => directory;

            set
            {
                directory = value;
                OnPropertyChanged();
            }
        }


        private string? _fileName;
        [StringLength(256, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Resources.TooManyCharsStrError)), 
            Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Resources.RequiredStrError))]
        public string? FileName
        {
            get => _fileName; 

            set
            {
                directory = value;

                OnPropertyChanged();
            }
        }


        public Command InvokeDirectoryDialog
        {
            get
            {
                return new Command
                    (
                        obj => Dialog.InvokeFolderBrowser(Directory)
                    );
            }
        }


        public FileData(string extension)
        {
            Extension = extension;
        }
    }
}
