using System.IO;

namespace Oil_level_glass.ViewModels.Windows.About
{
    public class AboutViewModel : ViewModelBase
    {
        public string AboutText 
            => File.ReadAllText(_aboutPath);

        private readonly string _aboutPath;

        public AboutViewModel(string aboutPath)
        {
            _aboutPath = aboutPath;
        }
    }
}
