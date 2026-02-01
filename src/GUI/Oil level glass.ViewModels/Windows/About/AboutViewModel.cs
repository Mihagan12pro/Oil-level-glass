using System.IO;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;

namespace Oil_level_glass.ViewModels.Windows.About
{
    public class AboutViewModel : ViewModelBase
    {
        private double _scaleParameter;
        public double ScaleParameter
        {
            get 
            {
                return _scaleParameter; 
            }
            set
            {
                _scaleParameter = value; 
                OnPropertyChanged(nameof(ScaleParameter));
            }
        }

        public IDocumentPaginatorSource DocumentSource
        {
            get
            {
                XpsDocument doc = new XpsDocument(_aboutPath, FileAccess.Read);

                return doc.GetFixedDocumentSequence();
            }
        }

        private readonly string _aboutPath;

        public AboutViewModel(string aboutPath)
        {
            _aboutPath = aboutPath;

            ScaleParameter = 20;
        }
    }
}
