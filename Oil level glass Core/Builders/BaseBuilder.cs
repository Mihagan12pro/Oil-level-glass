using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;
using Oil_level_glass_Core.Interfaces;
using Utils;

namespace Oil_level_glass_Core.Builders
{
    public abstract class BaseBuilder : BaseAPI7Object, ICreator3D
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

        public IPart7 Part { get; }

        public IModelContainer ModelContainer { get; }

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
