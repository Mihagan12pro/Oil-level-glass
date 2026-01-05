using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core;
using Oil_level_glass.Model.Data.Entities.Parts;

namespace Oil_level_glass.COM
{
    internal abstract class ComSolidPartCreator<TModel> : ComCreator, ISolidPartCreator<TModel>
        where TModel : BaseDetailModel
    {
        public IPart7? Part7 { get; private set; }

        public IPartDocument? PartDocument { get; private set; }

        public IModelContainer ModelContainer { get; private set; }
        public TModel PartModel { get; set; }

        public override void SaveFile()
        {
            PartDocument!.SaveAs(PartModel.File);
        }

        public void EditAppearances()
        {
            Part7!.SetAppearance(PartModel!.Appereance);
        }

        public void EditMaterial()
        {
            Part7!.SetMaterial(PartModel!.Material!);   
        }

        public override void EditNaming()
        {
            Part7!.SetName(PartModel!.File!.Name);
        }

        public override void EditSavingParameter()
        {
            Part7!.SetFileName(PartModel!.File!);
        }

        public override void Initialize()
        {
            base.Initialize();

            PartDocument = KompasObject.GetPartDocument();

            Part7 = PartDocument.TopPart;

            ModelContainer = (IModelContainer)Part7;
        }
    }
}
