using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core;
using Oil_level_glass.Model.Data.Entities.Parts;

namespace Oil_level_glass.COM
{
    internal abstract class ComAssemblyPartCreator<IPartModel> : ComCreator, IAssemblyPartCreator<IPartModel>
        where IPartModel : BaseAssemblyModel
    {
        public IPart7 AssemblyPart7 { get; set; }

        public IAssemblyDocument? AssemblyDocument { get; private set; }
        public IPartModel PartModel { get; set; }

        public override void SaveFile()
        {
            AssemblyDocument!.SaveAs(PartModel.File);
        }

        public override void EditNaming()
        {
             AssemblyPart7!.SetName(PartModel!.File!.Name);
        }

        public override void EditSavingParameter()
        {
             AssemblyPart7!.SetFileName(PartModel!.File!);
        }

        public override void Initialize()
        {
            base.Initialize();

            AssemblyDocument = KompasObject.GetAssemblyDocument();

            AssemblyPart7 = AssemblyDocument.TopPart;
        }
    }
}
