
using Oil_level_glass.Services;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class BaseWizardViewModel : BaseViewModel
    {

        protected string ?saveFolder;

        public string? SaveFolder
        {
           get
           {
                return saveFolder;
           }
           protected set
           {
                saveFolder = value;

                OnPropertyChanged();
           }
        }


        protected string? fileName;

        public string ?FileName
        {
            get
            {
                return fileName;
            }
            protected set
            {
                fileName = value; 
                OnPropertyChanged();
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
    }
}
