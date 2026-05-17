using Kompas6API5;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Core.COM.Api7.Extensions
{
    internal static class IKompasDocument2DExtensions
    {
        public static ICircle AddCircle(this IKompasDocument2D document2D)
        {
            IViewsAndLayersManager viewsAndLayersManager = document2D.ViewsAndLayersManager;
            IView view = viewsAndLayersManager.Views.ActiveView;
            IDrawingContainer drawingContainer = (IDrawingContainer)view;

            return drawingContainer.Circles.Add();
        }

        public static IPoint AddPoint(this IKompasDocument2D document2D)
        {
            IViewsAndLayersManager viewsAndLayersManager = document2D.ViewsAndLayersManager;
            IView view = viewsAndLayersManager.Views.ActiveView;
            IDrawingContainer drawingContainer = (IDrawingContainer)view;

            return drawingContainer.Points.Add();
        }
    }
}
