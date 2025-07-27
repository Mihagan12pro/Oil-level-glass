using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        protected int formSize;
        public virtual int FormSize
        {
            protected get
            {
                return formSize; 
            }
            set 
            {
                formSize = value;
                OnPropertyChanged();
            }
        }
    }
}
