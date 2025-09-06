using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Data.Structs
{
    internal struct SketchEditor
    {
        private IViewsAndLayersManager _viewsAndLayersManager;

        private IView _view;

        internal IDrawingContainer DrawingContainer { get; private set; }

        private IKompasDocument2D _document2D;

        public ISketch Sketch
        {
            set
            {
                _document2D = value.BeginEdit();

                //new Point3D
            }
        }
    }
}
