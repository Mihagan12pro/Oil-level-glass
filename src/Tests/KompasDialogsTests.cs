using Oil_level_glass.COM.Classic.Glass;
using Oil_level_glass.COM.KompasDialogs;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Tests
{
    public class KompasDialogsTests
    {
        private readonly GlassModel _glassModel;

        [Fact()]
        public void TestMaterial()
        {
            ComDialogsProvider dialogsProvider = new ComDialogsProvider();

            IMaterialDialog materialDialog = dialogsProvider.GetMaterialDialog();

            var material = new Glass();

            materialDialog.SelectMaterial(material);
        }

        [Fact()]
        public void TestColor()
        {
            ComGlassPartCreatorsFactory partCreatorsFactory = new ComGlassPartCreatorsFactory();

            IGlassPartCreator glassPartCreator = partCreatorsFactory.GetCreator();

            glassPartCreator.PartModel = _glassModel;


            glassPartCreator.Initialize();
            glassPartCreator.AddSketch1();
            glassPartCreator.ExtrudeSketch1();

            ComDialogsProvider dialogsProvider = new ComDialogsProvider();

            IColorDialog colorDialog = dialogsProvider.GetColorDialog();
            colorDialog.SelectColor(_glassModel.Appereance);

            glassPartCreator.EditAppearances();
            glassPartCreator.EditMaterial();
            glassPartCreator.EditNaming();
            glassPartCreator.EditSavingParameter();

            glassPartCreator.SaveFile();
        }

        public KompasDialogsTests()
        {
            _glassModel = new GlassModel()
            {
                Height = 2,

                ExternalDiameter = 60
            };
            _glassModel!.File!.Folder = @"C:\Сборка";
            _glassModel!.File!.Name.Naming = "Линза";
            _glassModel!.File!.Name.Marking = "МПСТ.000.000.002";
        }
    }
}
