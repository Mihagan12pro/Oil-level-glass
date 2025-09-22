using APIv7_gateway.ModelObjects;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway
{
    public class SketchEditor
    {
        private IKompasDocument2D? _kompasDocument2D;

        private IViewsAndLayersManager? _viewsAndLayersManager;

        private IView? _view;

        private ISketch _sketch;

        internal IKompasDocument2D? KompasDocument2D
        {
            get
            {
                return _kompasDocument2D;
            }
            private set
            {
                _kompasDocument2D = value;

                _viewsAndLayersManager = _kompasDocument2D?.ViewsAndLayersManager;

                _view = _viewsAndLayersManager?.Views.ActiveView;
            }
        }

        internal IDrawingContainer? DrawingContainer => _view as IDrawingContainer;

        public void EndEdit()
        {
            _sketch?.EndEdit();
        }

        internal SketchEditor(ISketch sketch)
        {
            _sketch = sketch;

            KompasDocument2D = _sketch?.BeginEdit();
        }
    }
}
