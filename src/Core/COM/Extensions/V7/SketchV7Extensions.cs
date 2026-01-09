using Kompas6API5;
using Kompas6Constants3D;
using KompasAPI7;

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

        public static IVertex[] GetVertices(this ISketch sketch)
        {
            IFeature7 feature = (IFeature7)sketch;

            object obj = feature.ModelObjects[Obj3dType.o3d_vertex];

            List<IVertex> vertices = [];

            if (obj is object[])
            {
                object[] objs = (object[])obj;

                foreach (var o in objs)
                {
                    if (o is IVertex)
                    {
                        vertices.Add((IVertex)o);
                    }
                }
            }
            else
            {
                vertices.Add((IVertex)obj);
            }

            return vertices.ToArray();
        }
    }
}
