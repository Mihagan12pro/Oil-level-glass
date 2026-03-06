using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.ViewModels.Commands;

namespace Oil_level_glass.ViewModels.Windows.Editors
{
    public class GlassEditorViewModel : EditorViewModel
    {
        public readonly GlassModel GlassModel;

        public override RelayCommand CancelCommand
        {
            get
            {
                return new RelayCommand((obj) => 
                {
                    closeAction.Invoke();
                });
            }
        }

        public GlassEditorViewModel(Action closeAction, GlassModel glassModel)
            : base(closeAction)
        {
            GlassModel = glassModel;
        }
    }
}
