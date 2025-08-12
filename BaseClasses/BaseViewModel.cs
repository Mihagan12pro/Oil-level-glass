using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {
        public readonly Color ErrorBackColor = Color.FromArgb(254, 210, 203);

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
