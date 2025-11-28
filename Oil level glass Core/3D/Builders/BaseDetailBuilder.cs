using Kompas6Constants;
using KompasAPI7;
using Oil_level_glass.Model.Data.Entities.Parts;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Other;
using Utils;

namespace Oil_level_glass_Core.Builders
{
    public abstract class BaseDetailBuilder : Base3DCreator
    {
        protected Sketchs sketchs;

        protected Extrusions extrusions;

        protected IKompasDocument2D? document2D;

        protected IDrawingContainer drawingContainer;

        protected ISymbols2DContainer symbols2dContainer;

        protected IViewsAndLayersManager viewsAndLayersManager;

        protected IView view;

        public override void Create()
        {
            SetMaterial();
            SetAppearance();
            
            base.Create();
        }


        protected void InitDrawingContainer()
        {
            viewsAndLayersManager = document2D!.ViewsAndLayersManager;
            view = viewsAndLayersManager.Views.ActiveView;
            drawingContainer = (IDrawingContainer)view;
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

        protected void AlignPoint(IDrawingObject targetObject, int targetIndex, IDrawingObject partnerObject, int partnerIndex, bool isHorisontal)
        {
            IDrawingObject1 drawingObject1 = (IDrawingObject1)targetObject;

            IParametriticConstraint parametricConstraint = drawingObject1.NewConstraint();
            parametricConstraint.Index = targetIndex;
            parametricConstraint.Partner = partnerObject;
            parametricConstraint.PartnerIndex = partnerIndex;

            if (isHorisontal)
            {
                parametricConstraint.ConstraintType = ksConstraintTypeEnum.ksCHAlignPoints;
            }
            else
                parametricConstraint.ConstraintType = ksConstraintTypeEnum.ksCVAlignPoints;

            parametricConstraint.Create();
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
            Material? material = ((BaseDetailModel)EntityModel).Material;

            Part.SetMaterial(material!.Tittle, material!.Density);
            IHatchParam hatchParameter = Part.HatchParam;
            hatchParameter.Style = material.HatchStyle;

            Part.Update();
        }

        protected void SetAppearance()
        {
            IColorParam7 colorParameter = (IColorParam7)modelContainer;

            Appereance appearance = ((BaseDetailModel)EntityModel).Appereance;

            colorParameter.SetAdvancedColor(
                appearance.Color,

                appearance.Ambient,

                appearance.Diffuse,

                appearance.Specularity,

                appearance.Shininess,

                appearance.Transparency,

                appearance.Emission
            );

            Part.Update();
        }


        public BaseDetailBuilder(bool createNewDocument) : base(createNewDocument)
        {
            if (createNewDocument)
                kompasDocument = application?.Documents.Add(DocumentTypeEnum.ksDocumentPart);
            else
                kompasDocument = application?.ActiveDocument;

            Part = (kompasDocument as IPartDocument)!.TopPart;
            IPartDocument partDocument = (IPartDocument)kompasDocument!;
            Part = partDocument!.TopPart;

            modelContainer = (IModelContainer)Part;

            sketchs = modelContainer.Sketchs;

            extrusions = modelContainer.Extrusions;
        }
    }
}
