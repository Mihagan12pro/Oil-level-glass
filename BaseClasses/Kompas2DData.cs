using Oil_level_glass.Enums;
using Oil_level_glass.Services;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Oil_level_glass.Delegates;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class Kompas2DData : BaseKompasData
    {
        private string? _fileName;
        [Description("Имя файла")]
        public string? FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;


                ValidateFileName();
                OnPropertyChanged();
            }
        }


        private string? _folderPath;

        [Description("Путь к папке сохранения")]
        public string? FolderPath
        {
            get
            {
                return _folderPath;
            }
            set
            {
                _folderPath = value;

                ValidateFolderPath();
                OnPropertyChanged();
            }
        }


        public Command InvokeFolderBrowserDialog
        {
            get
            {
                return new Command
                    (
                        obj => FolderPath = Dialog.InvokeFolderBrowser(FolderPath)
                    );
            }
        }


        protected void AddError(string propertyName, string error, InputError input)
        {
            if (!errorsByPropertyName.ContainsKey(propertyName))
                errorsByPropertyName[propertyName] = new List<(string, InputError)>();

            if (!errorsByPropertyName[propertyName].Contains((error, input)))
            {
                errorsByPropertyName[propertyName].Add((error, input));
                OnErrorsChanged(propertyName);
            }
        }

        protected void ClearErrors(string propertyName)
        {
            if (errorsByPropertyName.ContainsKey(propertyName))
            {
                errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }


        private void ValidateFileName()
        {
            if (!Validator<Kompas2DData>.CheckRequiredField(nameof(FileName), FileName, new ErrorAdder(AddError), new ErrorClearer(ClearErrors)))
            {
                Validator<Kompas2DData>.CheckFileName(nameof(FileName), FileName, new ErrorAdder(AddError), new ErrorClearer(ClearErrors));
            }
        }


        private void ValidateFolderPath()
        {
            if (!Validator<Kompas2DData>.CheckRequiredField(nameof(FolderPath), FolderPath, new ErrorAdder(AddError), new ErrorClearer(ClearErrors)))
            {
                Validator<Kompas2DData>.CheckPath(nameof(FolderPath), FolderPath, new ErrorAdder(AddError), new ErrorClearer(ClearErrors));
            }
        }


        public Kompas2DData()
        {
            FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
