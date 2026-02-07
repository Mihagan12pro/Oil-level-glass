using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.ViewModels.Commands;
using Oil_level_glass.ViewModels.Services.Windows;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel 
        : ViewModelBase
    {
        private readonly IKompasDialogsService _kompasDialogsService;

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

        public RelayCommand SelectMetalCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectMaterial(Metal);
                });
            }
        }

        public RelayCommand SelectGlassCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectMaterial(Glass);
                });
            }
        }

        public RelayCommand SelectRubberCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _kompasDialogsService.SelectMaterial(Rubber);
                });
            }
        }

        public Wizard3dViewModel(IKompasDialogsService kompasDialogsService)
        {
            _kompasDialogsService = kompasDialogsService;

            Glass = new Glass();
            Metal = new Metal();
            Rubber = new Rubber();
        }
    }
}
