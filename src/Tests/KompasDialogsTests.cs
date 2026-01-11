using Oil_level_glass.COM.Classic.Glass;
using Oil_level_glass.COM.KompasDialogs;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Tests
{
    public class KompasDialogsTests
    {
        private readonly GlassModel _glassModel;

        [Fact()]
        public void TestFolders()
        {
            ComDialogsProvider dialogsProvider = new ComDialogsProvider();

            var file = new AssemblyFile();

            IFoldersDialog foldersDialog = dialogsProvider.GetFoldersDialog();

            foldersDialog.SelectFolder(file);
        }

        [Fact()]
        public void TestThread2()
        {
            ComDialogsProvider dialogsProvider = new ComDialogsProvider();

            IThreadsDialog threadDialog = dialogsProvider.GetThreadsDialog();

            ThreadModel threadModel = new ThreadModel();

            threadDialog.SelectThread(threadModel, 20, true);
        }


        [Fact()]
        public void TestThread1()
        {
            ComDialogsProvider dialogsProvider = new ComDialogsProvider();

            IThreadsDialog threadDialog = dialogsProvider.GetThreadsDialog();

            ThreadModel threadModel = new ThreadModel();

            threadDialog.SelectThread(threadModel);
        }

        [Fact()]
        public void TestMaterial()
        {
            ComDialogsProvider dialogsProvider = new ComDialogsProvider();

            IMaterialsDialog materialDialog = dialogsProvider.GetMaterialsDialog();

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

            IColorsDialog colorDialog = dialogsProvider.GetColorsDialog();
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
