using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Extensions
{
    internal static class SketchV7Extensions
    {
        public static IDrawingContainer GetDrawingContainer(this ISketch sketch)
        {
            IKompasDocument2D document2D = sketch.BeginEdit();

            IViewsAndLayersManager viewsAndLayersManager = document2D.ViewsAndLayersManager;
            IView view = viewsAndLayersManager.Views.ActiveView;
            IDrawingContainer drawingContainer = (IDrawingContainer)view;

            return drawingContainer;
        }
    }
}
