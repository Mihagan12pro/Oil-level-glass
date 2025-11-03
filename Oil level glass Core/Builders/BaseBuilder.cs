using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;
using Oil_level_glass_Core.Delegates;
using Utils;

namespace Oil_level_glass_Core.Builders
{
    public abstract class BaseBuilder : BaseAPI7Object
    {
        public virtual void Build()
        {
            SetMaterial();
            SetAppearance();
            SaveDocument();
        }

        public required PartFile File { get; set; }

        public required Material Material { get; set; }

        public required Appereance Appearance { get; set; }

        internal IPart7 Part { get; }

        internal IModelContainer ModelContainer { get; }

        protected Sketchs sketchs;

        protected Extrusions extrusions;

        protected IKompasDocument2D? document2D;

        protected IDrawingContainer drawingContainer;

        protected ISymbols2DContainer symbols2dContainer;

        protected IViewsAndLayersManager viewsAndLayersManager;

        protected IView view;

        protected void InitDrawingContainer()
        {
            viewsAndLayersManager = document2D!.ViewsAndLayersManager;
            view = viewsAndLayersManager.Views.ActiveView;
            drawingContainer = (IDrawingContainer)view;
        }


        protected override void SaveDocument()
        {
            Part.Marking = File.Name.Marking;
            Part.Name = File.Name.Naming;
            Part.Update();

            kompasDocument?.SaveAs(File.FullName);
        }


        protected void AddVariableToSolidBody(IFeature7 feature, string expression, string parameterNote, bool externalOnly = false, bool inSource = false)
        {
            IVariable7? variable = null;

            foreach(IVariable7 v in ArrayMaster.ObjectToArray(feature.Variables[externalOnly, inSource]))
            {
                if (v.ParameterNote == parameterNote)
                    variable = v;
            }

            if (variable == null)
                throw new Exception($"The objectVariable with parameter parameterNote {parameterNote} does not exists!");
     
            variable.Expression = expression;
            //variable.Note = "1";

            Part.Update();
        }


        protected void AddVariableToDimension(IDrawingObject dimension, IFeature7 feature, string expression, string displayName, bool externalOnly = false, bool inSource = false)
        {
            IDrawingObject1 drawingObject1 = (IDrawingObject1)dimension;
      
            IParametriticConstraint parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = Kompas6Constants.ksConstraintTypeEnum.ksCDimWithVariable;
            parametriticConstraint.Variable = displayName;
            parametriticConstraint.Expression = expression;
            parametriticConstraint.Create();

            parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = Kompas6Constants.ksConstraintTypeEnum.ksCFixedDim;
            parametriticConstraint.Create();

            


            IVariable7 variable = feature.Variable[externalOnly, inSource, displayName];
            variable.Expression = expression;
         
        }


        protected void MergePoints(IDrawingObject targetObject, int targetIndex, IDrawingObject partnerObject, int partnerIndex)
        {
            IDrawingObject1 drawingObject = (IDrawingObject1)targetObject;

            IParametriticConstraint parametricConstraint = drawingObject.NewConstraint();
            parametricConstraint.Index = targetIndex;
            parametricConstraint.Partner = partnerObject;
            parametricConstraint.PartnerIndex = partnerIndex;
            parametricConstraint.ConstraintType = ksConstraintTypeEnum.ksCMergePoints;

            parametricConstraint.Create();
        }


        protected void MakePointFixed(IDrawingObject drawingObject, int index = 0)
        {
            IDrawingObject1 drawingObject1 = (IDrawingObject1)drawingObject;

            IParametriticConstraint parametricConstraint = drawingObject1.NewConstraint();
            parametricConstraint.Index = index;
            parametricConstraint.ConstraintType = ksConstraintTypeEnum.ksCFixedPoint;

            parametricConstraint.Create();
        }


        protected void MakeObjectsConcentric(IDrawingObject targetObject, IDrawingObject partnerObject)
        {
            IDrawingObject1 drawingObject = (IDrawingObject1)targetObject;

            IParametriticConstraint parametricConstraint = drawingObject.NewConstraint();
            parametricConstraint.Partner = partnerObject;
            parametricConstraint.ConstraintType = ksConstraintTypeEnum.ksCConcentricity;
            parametricConstraint.Index = 0;

            parametricConstraint.Create();
        }


        protected void InitSymbolContaiber()
        {
            viewsAndLayersManager = document2D!.ViewsAndLayersManager;
            view = viewsAndLayersManager.Views.ActiveView;
            symbols2dContainer = (ISymbols2DContainer)view;
        }


        protected void SetMaterial()
        {
            Part.SetMaterial(Material.Tittle, Material.Density);
            IHatchParam hatchParameter = Part.HatchParam;
            hatchParameter.Style = Material.HatchStyle;

            Part.Update();
        }

        protected void SetAppearance()
        {
            IColorParam7 colorParameter = (IColorParam7)ModelContainer;

            colorParameter.SetAdvancedColor(
                Appearance.Color,

                Appearance.Ambient,

                Appearance.Diffuse,

                Appearance.Specularity,

                Appearance.Shininess,

                Appearance.Transparency,

                Appearance.Emission
            );

            Part.Update();
        }


        internal void GetFaceByPoint(object[] faces, ref IFace targetFace, CheckFace checkFace, double x = 0, double y = 0, double z = 0)
        {
            foreach (var obj in faces)
            {
                if (obj is IFace face)
                {
                    if (checkFace.Invoke(face))
                    {
                        object[] edges = ArrayMaster.ObjectToArray(face.LimitingEdges);


                        IEdge? edge = null;

                        GetEdgeByPoint(edges, ref edge!, x, y, z);

                        if (edge != null)
                        {
                            targetFace = face;

                            break;
                        }
                    }
                }
            }
        }


        internal void GetEdgeByPoint(object[] edges, ref IEdge targetEdge, double x = 0, double y = 0, double z = 0)
        {
            
            foreach(var obj in edges)
            {
                if (obj is IEdge edge)
                {
                    edge.GetPoint(true, out double x1, out double y1, out double z1);

                    if (x1 == x && y1 == y && z1 == z)
                    {
                        targetEdge = edge;

                        break;
                    }
                }
            }
        }


        public BaseBuilder(bool createNewDocument) : base(createNewDocument)
        {
            if (createNewDocument)
                kompasDocument = application?.Documents.Add(DocumentTypeEnum.ksDocumentPart);
            else
                kompasDocument = application?.ActiveDocument;

            Part = (kompasDocument as IPartDocument)!.TopPart;
            IPartDocument partDocument = (IPartDocument)kompasDocument!;
            Part = partDocument!.TopPart;

            ModelContainer = (IModelContainer)Part;

            sketchs = ModelContainer.Sketchs;

            extrusions = ModelContainer.Extrusions;
        }
    }
}
