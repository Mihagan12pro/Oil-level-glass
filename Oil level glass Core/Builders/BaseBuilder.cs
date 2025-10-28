using Kompas6Constants;
using Kompas6Constants3D;
using KompasAPI7;
using KompasData.KompasFile;
using KompasData.Materials;
using KompasData.Other;
using Oil_level_glass_Core.Interfaces;

namespace Oil_level_glass_Core.Builders
{
    public abstract class BaseBuilder : BaseAPI7Object, ICreator3D
    {
        public abstract void Build();

        public required PartFile File { get; set; }

        public required Material Material { get; set; }

        public required Appereance Appearance { get; set; }

        public IPart7 Part { get; }

        public IModelContainer ModelContainer { get; }

        protected Sketchs sketchs;

        protected Extrusions extrusions;

        protected IKompasDocument2D? document2D;

        protected IDrawingContainer drawingContainer;

        protected ISymbols2DContainer symbols2DContainer;

        protected IViewsAndLayersManager viewsAndLayersManager;

        protected IView view;

        protected void InitDrawingContainer()
        {
            viewsAndLayersManager = document2D!.ViewsAndLayersManager;
            view = viewsAndLayersManager.Views.ActiveView;
            drawingContainer = (IDrawingContainer)view;
        }


        protected void InitSymbolContaiber()
        {
            viewsAndLayersManager = document2D!.ViewsAndLayersManager;
            view = viewsAndLayersManager.Views.ActiveView;
            symbols2DContainer = (ISymbols2DContainer)view;
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
