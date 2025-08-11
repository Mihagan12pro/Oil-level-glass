using Oil_level_glass.Enums;
using Oil_level_glass.Services;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Oil_level_glass.Delegates;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class KompasData : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        protected readonly Dictionary<string, List<(string, InputError)>> errorsByPropertyName = new Dictionary<string, List<(string, InputError)>>();
        public Dictionary<string, List<(string, InputError)>> ErrorsByPropertyName => errorsByPropertyName;


        public bool HasErrors => errorsByPropertyName.Any();


        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;


        public event PropertyChangedEventHandler? PropertyChanged;


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


        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public IEnumerable GetErrors(string? propertyName)
        {
            return errorsByPropertyName.ContainsKey(propertyName) ? errorsByPropertyName[propertyName] : null;
        }


        protected void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
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
            if (!Validator<KompasData>.CheckRequiredField(nameof(FileName), FileName, new ErrorAdder(AddError), new ErrorClearer(ClearErrors)))
            {
                Validator<KompasData>.CheckFileName(nameof(FileName), FileName, new ErrorAdder(AddError), new ErrorClearer(ClearErrors));
            }
        }


        private void ValidateFolderPath()
        {
            if (!Validator<KompasData>.CheckRequiredField(nameof(FolderPath), FolderPath, new ErrorAdder(AddError), new ErrorClearer(ClearErrors)))
            {
                Validator<KompasData>.CheckPath(nameof(FolderPath), FolderPath, new ErrorAdder(AddError), new ErrorClearer(ClearErrors));
            }
        }


        public KompasData()
        {
            FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
