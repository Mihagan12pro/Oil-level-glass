using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.Structs.FieldAppeareance
{
    internal struct FieldApperance : INotifyPropertyChanged
    {
        public readonly string Propery;


        private Color _backColor;
        public Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;

                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public FieldApperance()
        {
            
        }
    }
}
