using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Extensions.V7
{
    internal static class SketchV7Extensions
    {
        public static void AddVariableToDimension(this ISketch sketch, IDrawingObject drawingObject, string variable, string expression)
        {
            IDrawingObject1 drawingObject1 = (IDrawingObject1)drawingObject;
            IParametriticConstraint parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = Kompas6Constants.ksConstraintTypeEnum.ksCDimWithVariable;
            parametriticConstraint.Variable = variable;
            parametriticConstraint.Expression = expression;
            parametriticConstraint.Create();

            parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = Kompas6Constants.ksConstraintTypeEnum.ksCFixedDim;
            parametriticConstraint.Create();

            IFeature7? feature = sketch as IFeature7;


            IVariable7 variableSketch = feature!.Variable[false, false, variable];
            variableSketch.Expression = expression;
        }

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
