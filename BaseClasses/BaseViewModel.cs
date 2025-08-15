using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.TabControl;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        //private TabPageCollection _tabsCollection;

        public TabPageCollection? TabPages { get; set; }
    }
}
