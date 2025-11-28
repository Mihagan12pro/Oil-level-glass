using Oil_level_glass.Model.Data;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Materials;

namespace Oil_level_glass.Tests
{
    public class ModelValidationTests
    {
        private readonly GlassModel _glassModel = new GlassModel();

        private readonly OilLevelGlassModel _oilLevelGlassModel = new OilLevelGlassModel();

        private readonly Glass _glass = new Glass();
        private readonly Metal _metal = new Metal();
        private readonly Rubber _rubber = new Rubber();
    
        [Fact()]
        public void GlassModelInvalidValuesTests()
        {
            _glassModel.Height = -1;
            _glassModel.ExternalDiameter = -1;

            _glassModel.File!.Folder = "";
            _glassModel.File.Name.Naming = "                                    ";

            KompasFile file = _glassModel.File;

            Assert.Equal(BaseModel.TooSmallValueError, _glassModel[nameof(_glassModel.Height)]);
            Assert.Equal(BaseModel.TooSmallValueError, _glassModel[nameof(_glassModel.ExternalDiameter)]);

            Assert.Equal(BaseModel.DirectoryDoesNotExistsError, file[nameof(file.Folder)]);

            Assert.Equal(BaseModel.DirectoryDoesNotExistsError, _glassModel.File[nameof(_glassModel.File.Folder)]);

            Assert.Equal(BaseModel.EmptyStringError, _glassModel.File.Name[nameof(_glassModel.File.Name.Naming)]);
            Assert.Equal(BaseModel.EmptyStringError, _glassModel.File.Name[nameof(_glassModel.File.Name.Marking)]);
        }

        [Fact]
        public void GlassModelCorrectValuesTests()
        {
            _glassModel.Height = 1;
            _glassModel.ExternalDiameter = 1;

            _glassModel.File!.Folder = "C:\\Users\\kargi\\Downloads\\Telegram Desktop";
            _glassModel.File.Name.Naming = "1";

            KompasFile file = _glassModel.File;

            Assert.Equal(string.Empty, _glassModel[nameof(_glassModel.Height)]);
            Assert.Equal(string.Empty, _glassModel[nameof(_glassModel.ExternalDiameter)]);

            Assert.Equal(string.Empty, file[nameof(file.Folder)]);

            Assert.Equal(string.Empty, _glassModel.File[nameof(_glassModel.File.Folder)]);

            Assert.Equal(string.Empty, _glassModel.File.Name[nameof(_glassModel.File.Name.Naming)]);
        }

        [Fact]
        public void OilLevelGlassInvalidValuesTests()
        {
            Assert.Equal(BaseModel.EmptyStringError, _oilLevelGlassModel[nameof(_oilLevelGlassModel.HousingPath)]);
            Assert.Equal(BaseModel.EmptyStringError, _oilLevelGlassModel[nameof(_oilLevelGlassModel.StripPath)]);
            Assert.Equal(BaseModel.EmptyStringError, _oilLevelGlassModel[nameof(_oilLevelGlassModel.GlassPath)]);

            _oilLevelGlassModel.HousingPath = "C:\\foo.m3d";
            _oilLevelGlassModel.GlassPath = "C:\\foo.m3d";
            _oilLevelGlassModel.StripPath = "C:\\foo.m3d";

            Assert.Equal(BaseModel.FileDoesNotExistsError, _oilLevelGlassModel[nameof(_oilLevelGlassModel.HousingPath)]);
            Assert.Equal(BaseModel.FileDoesNotExistsError, _oilLevelGlassModel[nameof(_oilLevelGlassModel.StripPath)]);
            Assert.Equal(BaseModel.FileDoesNotExistsError, _oilLevelGlassModel[nameof(_oilLevelGlassModel.GlassPath)]);
        }

        [Fact]
        public void OilLevelGlassCorrectValuesTests()
        {
            _oilLevelGlassModel.HousingPath = @"C:\Users\kargi\OneDrive\Документы\foo.m3d";
            _oilLevelGlassModel.GlassPath = @"C:\Users\kargi\OneDrive\Документы\foo.m3d";
            _oilLevelGlassModel.StripPath = @"C:\Users\kargi\OneDrive\Документы\foo.m3d";

            Assert.Equal(string.Empty, _oilLevelGlassModel[nameof(_oilLevelGlassModel.HousingPath)]);
            Assert.Equal(string.Empty, _oilLevelGlassModel[nameof(_oilLevelGlassModel.StripPath)]);
            Assert.Equal(string.Empty, _oilLevelGlassModel[nameof(_oilLevelGlassModel.GlassPath)]);
        }

        [Fact]
        public void MaterialInvalidValuesTests()
        {
            _glass.Density = 2.19;

            Assert.Equal(BaseModel.InvalidRangeError, _glass[nameof(_glass.Density)]);

            _glass.Density = 7.5001;


            Assert.Equal(BaseModel.InvalidRangeError, _glass[nameof(_glass.Density)]);

            _glass.Tittle = "                             ";

            Assert.Equal(BaseModel.EmptyStringError, _glass[nameof(_glass.Tittle)]);
        }

        [Fact]
        public void MaterialCorrectValuesTests()
        {
            _glass.Density = 2.2;

            Assert.Equal(string.Empty, _glass[nameof(_glass.Density)]);
            
            _glass.Density = 7.5;

            Assert.Equal(string.Empty, _glass[nameof(_glass.Density)]);
        }
    }
}
