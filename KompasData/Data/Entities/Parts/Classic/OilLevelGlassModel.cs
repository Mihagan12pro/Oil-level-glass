using Oil_level_glass.Model.Data.KompasFile;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic;

public class OilLevelGlassModel : BaseEntityModel
{
    public string? GlassPath, HousingPath, StripPath;

    public OilLevelGlassModel()
    {
        File = new AssemblyFile();
    }

    public double MainDiameter { get; set; }

    public double MainHeight { get; set; }

    public int ScrewHolesCount { get; set; }

    public double CentralHoleDiameter { get; set; }

    public double GlassDiameter { get; set; }

    public double GlassWidth { get; set; }

    public double GlassSocketHeight { get; set; }

    public ThreadModel? ThreadModel { get; set; }

    public ChamferModel Chamfer { get; } = new() { Angle = 45, Length = 5 };

    protected override string CheckField(string columnName)
    {
        string error = string.Empty;

        switch (columnName)
        {
            case nameof(MainDiameter):
                if (MainDiameter <= 0)
                    error = TooSmallValueError;

                break;

            case nameof(MainHeight):
                {
                    if (MainHeight <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(GlassSocketHeight):
                {
                    if (GlassSocketHeight <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(GlassDiameter):
                {
                    if (GlassDiameter <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(CentralHoleDiameter):
                {
                    if (CentralHoleDiameter <= 0)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(ScrewHolesCount):
                {
                    if (ScrewHolesCount < 4)
                        error = TooSmallValueError;

                    break;
                }

            case nameof(GlassPath):
                {
                    if (!new FileInfo(GlassPath!).Exists)
                        error = FileDoesNotExistsError;
                    break;
                }
            case nameof(StripPath):
                {
                    if (!new FileInfo(StripPath!).Exists)
                        error = FileDoesNotExistsError;
                    break;
                }
            case nameof(HousingPath):
                {
                    if (!new FileInfo(HousingPath!).Exists)
                        error = FileDoesNotExistsError;
                    break;
                }
        }

        return error;
    }
}