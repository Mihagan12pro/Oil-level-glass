using Oil_level_glass.Services;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class BaseWizardViewModel : BaseViewModel
    {
        private string ?_saveFolder;

        public string? SaveFolder
        {
           get
           {
                return _saveFolder;
           }
           protected set
           {
                _saveFolder = value;

                OnPropertyChanged();
           }
        }


        private string? _fileName;
        public string ?FileName
        {
            get
            {
                return _fileName;
            }
            protected set
            {
                _fileName = value; 
                //OnPropertyChanged();

                
            }
        }


        private void SaveFolderValidation()
        {
            ClearErrors(nameof(SaveFolder));

            if (string.IsNullOrEmpty(SaveFolder))
            {
                AddError(nameof(SaveFolder), "Не выбрана папка для сохранения 3D моделей!");
            }
        }


        public Command ExecuteFolderBrowser
        {
            get
            {
                return new Command(
                        obj =>
                        {
                            FolderBrowserDialog dialog = new FolderBrowserDialog();
                            dialog.RootFolder = Environment.SpecialFolder.MyDocuments;

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                SaveFolder = dialog.SelectedPath;
                            }
                        }
                    );
            }
        }


        public BaseWizardViewModel()
        {
            SaveFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
