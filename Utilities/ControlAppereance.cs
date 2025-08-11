using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.Utilities
{
    internal class ControlAppearance : INotifyPropertyChanged
    {

        public readonly string Name;


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


        private bool _enabled;
        public bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;

                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public ControlAppearance(string name)
        {
            Name = name;

            BackColor = Color.White;
        }
    }
}
