using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.ViewModels.Commands;

namespace Oil_level_glass.ViewModels.Windows.Wizard3d
{
    public class Wizard3dViewModel 
        : ViewModelBase
    {
        private readonly IDialogsProvider _dialogsProvider;

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
                    IMaterialsDialog dialog = _dialogsProvider.GetMaterialsDialog();
                    dialog.SelectMaterial(Metal);
                });
            }
        }

        public Wizard3dViewModel(IDialogsProvider dialogsProvider)
        {
            _dialogsProvider = dialogsProvider;

            Glass = new Glass();
            Metal = new Metal();
            Rubber = new Rubber();
        }
    }
}
