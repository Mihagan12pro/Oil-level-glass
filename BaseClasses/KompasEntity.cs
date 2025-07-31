using KompasAPI7;
using Oil_level_glass.Services;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class KompasEntity : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        protected readonly Dictionary<string, List<string>> errorsByPropertyName = new Dictionary<string, List<string>>();


        public bool HasErrors => errorsByPropertyName.Any();


        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;


        public event PropertyChangedEventHandler? PropertyChanged;


        private string? _fileName;
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


        protected void AddError(string propertyName, string error)
        {
            if (!errorsByPropertyName.ContainsKey(propertyName))
                errorsByPropertyName[propertyName] = new List<string>();

            if (!errorsByPropertyName[propertyName].Contains(error))
            {
                errorsByPropertyName[propertyName].Add(error);
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
            ClearErrors(nameof(FileName));

            if (string.IsNullOrWhiteSpace(FileName))
                AddError(nameof(FileName), "У файла обязательно должно быть название!");

            if (new String(FileName).Length > 256)
                AddError(nameof(FileName), "Название файла не должно быть больше 256 символов!");
        }


        private void ValidateFolderPath()
        {
            ClearErrors(nameof(FolderPath));

            if (string.IsNullOrWhiteSpace(FolderPath))
            {
                AddError(nameof(FolderPath), "Задайте папку, в которую должен будут сохранен файл!");

                return;
            }

            if (!System.IO.Directory.Exists(FolderPath))
                AddError(nameof(FolderPath), "Данной папки не существует");
        }


        public KompasEntity()
        {
            FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
