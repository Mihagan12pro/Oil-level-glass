using KompasAPI7;
using Oil_level_glass_Core.Data.Files;
using Oil_level_glass_Core.Data.Materials;
using Oil_level_glass_Core.Data.Structs;

namespace Oil_level_glass_Core.Data.ModelProperties.Properties3D
{
    public record ModelPartProperties : Model3DProperties<IPartDocument>
    {
        public required Material Material { get; set; }

        public Appearance Appearance { get; set; }


        private IKompasDocument2D _kompasDocument2D;
        internal IKompasDocument2D KompasDocument2D 
        {
            get => _kompasDocument2D; 
            set
            {
                _kompasDocument2D = value;

                _viewsAndLayersManager = _kompasDocument2D.ViewsAndLayersManager;

                _view = _viewsAndLayersManager.Views.ActiveView;

                DrawingContainer = (IDrawingContainer)_view;
            }
        }


        private IViewsAndLayersManager _viewsAndLayersManager;


        private IView _view;


        internal IDrawingContainer DrawingContainer { get; private set; }


        internal ISketch? GetNewSketch()
        {
            return ModelContainer.Sketchs.Add();
        }


        public ModelPartProperties()
        {
            KompasFile = new PartFile();
        }
    }
}
