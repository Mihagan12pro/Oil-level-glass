using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel 
        : ViewModelBase
    {
        private Glass _material = null!;
        public Glass Glass
        {
            get 
            { 
                return _material; 
            }
            set
            {
                _material = value;
                OnPropertyChanged();
            }
        }

        private Metal _metal = null!;
        public Metal Metal
        {
            get
            {
                return _metal;
            }
            set
            {
                _metal = value;
                OnPropertyChanged();
            }
        }

        private Rubber _rubber;
        public Rubber Rubber
        {
            get
            {
                return _rubber;
            }
            set
            {
                _rubber = value;
                OnPropertyChanged();
            }
        }

        public Wizard3dViewModel()
        {
            Glass = new Glass();
            Metal = new Metal();
        }
    }
}
